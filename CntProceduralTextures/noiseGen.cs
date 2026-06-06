using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CntProceduralTextures
{

    public delegate float cnt_f1D(float x1);
    class noiseGen
    {


        private static float[] grad = new float[256];
        private static int[] p = {151,160,137,91,90,15,
 131,13,201,95,96,53,194,233,7,225,140,36,103,30,69,142,8,99,37,240,21,10,23,
 190, 6,148,247,120,234,75,0,26,197,62,94,252,219,203,117,35,11,32,57,177,33,
 88,237,149,56,87,174,20,125,136,171,168, 68,175,74,165,71,134,139,48,27,166,
 77,146,158,231,83,111,229,122,60,211,133,230,220,105,92,41,55,46,245,40,244,
 102,143,54, 65,25,63,161, 1,216,80,73,209,76,132,187,208, 89,18,169,200,196,
 135,130,116,188,159,86,164,100,109,198,173,186, 3,64,52,217,226,250,124,123,
 5,202,38,147,118,126,255,82,85,212,207,206,59,227,47,16,58,17,182,189,28,42,
 223,183,170,213,119,248,152, 2,44,154,163, 70,221,153,101,155,167, 43,172,9,
 129,22,39,253, 19,98,108,110,79,113,224,232,178,185, 112,104,218,246,97,228,
 251,34,242,193,238,210,144,12,191,179,162,241, 81,51,145,235,249,14,239,107,
 49,192,214, 31,181,199,106,157,184, 84,204,176,115,121,50,45,127, 4,150,254,
 138,236,205,93,222,114,67,29,24,72,243,141,128,195,78,66,215,61,156,180};

        float cloudCoverage = 0; // USER ADJUSTABLE
        float cloudDensity = 1; // USER ADJUSTABLE
        
        public System.Random r;
        public int Seed;


        public noiseGen(int seed)
        {
            init(seed);
        }

        private void init(int seed)
        {

            if (seed != 0)
            {
                Seed = seed;
                r = new Random(seed);
            }
            else
            {
                Random r1 = new Random();
                Seed = r1.Next(0, 32000);
                r = new Random(Seed);
            }

            InitPerlinPerm((uint)Seed);

        }

        public void PerlinCloudCoverage(float f)
        {
            cloudCoverage = clamp(f, 0, 1);
        }
        public void PerlinCloudDendity(float f)
        {
            cloudDensity = clamp(f, 0, 1);
        }

        private float clamp(float v, float min, float max)
        {
            if (v > max)
                return max;
            if (v < min)
                return min;
            return v;
        }

        private bool fastPerlin = true;
        private bool falloffPerlin = false;
        public void FastPerlin()
        {
            fastPerlin = true;
            falloffPerlin = false;
        }
        public void SlowPerlin()
        {
            fastPerlin = false;
            falloffPerlin = false;
        }
        public void FallOffPerlin()
        {
            fastPerlin = false;
            falloffPerlin = true;
        }


        private static void InitPerlinPerm(uint seed)
        {
            Random r = new Random((int)seed);
            for (uint i = 0; i < grad.GetLength(0); i++)
            {
                grad[i] = (r.Next(0, 32000) / 32000f);
            }
        }

        public void initPerlin(int seed)
        {
            if (seed == 0)
                seed = r.Next();
            InitPerlinPerm((uint)seed);
        }

        private float pseudoRandomFromPerm(int x, int y)
        {
            return grad[(x + p[y & 255]) % grad.GetLength(0)];
        }

        private float noise(float x, float y)
        {

            return pseudoRandomFromPerm((int)x, (int)y);
        }
        private float SmoothNoise_1(float x, float y)
        {
            float corners = (noise(x - 1f, y - 1f)
                             + noise(x + 1f, y - 1f)
                             + noise(x - 1f, y + 1f)
                             + noise(x + 1f, y + 1f))
                / 16f;
            float sides = (noise(x - 1f, y) + noise(x + 1f, y) + noise(x, y - 1f) + noise(x, y + 1f)) / 8f;
            float center = noise(x, y) / 4f;
            return (corners + sides + center);
        }
        //Cosine_Interpolate
        private float cos_Interpolate(float a, float b, float x)
        {
            float ft = x * 3.1415927f;
            float f = (1 - (float)Math.Cos(ft)) * .5f;
            return a - f * (a - b);
        }

        private float lin_Interpolate(float a, float b, float x)
        {
            return a - x * (a - b);

        }

        private float InterpolatedNoise_1(float x, float y)
        {
            int integer_X = (int)x;
            float fractional_X = x - integer_X;
            int integer_Y = (int)y;
            float fractional_Y = y - integer_Y;
            int integer_X1 = integer_X + 1;
            int integer_Y1 = integer_Y + 1;

            float v1 = SmoothNoise_1(integer_X, integer_Y);
            float v2 = SmoothNoise_1(integer_X1, integer_Y);
            float v3 = SmoothNoise_1(integer_X, integer_Y1);
            float v4 = SmoothNoise_1(integer_X1, integer_Y1);
            //faster:
            //float v1 = noise(integer_X, integer_Y, w, h);
            //float v2 = noise(integer_X1, integer_Y, w, h);
            //float v3 = noise(integer_X, integer_Y1, w, h);
            //float v4 = noise(integer_X1, integer_Y1, w, h);

            float i1 = cos_Interpolate(v1, v2, fractional_X);
            float i2 = cos_Interpolate(v3, v4, fractional_X);
            return cos_Interpolate(i1, i2, fractional_Y);
        }

        private float fast_InterpolatedNoise_1(float x, float y)
        {
            int integer_X = (int)x;
            float fractional_X = x - integer_X;
            int integer_Y = (int)y;
            float fractional_Y = y - integer_Y;
            int integer_X1 = integer_X + 1;
            int integer_Y1 = integer_Y + 1;

            //faster:
            float v1 = noise(integer_X, integer_Y);
            float v2 = noise(integer_X1, integer_Y);
            float v3 = noise(integer_X, integer_Y1);
            float v4 = noise(integer_X1, integer_Y1);

            float i1 = lin_Interpolate(v1, v2, fractional_X);
            float i2 = lin_Interpolate(v3, v4, fractional_X);
            return lin_Interpolate(i1, i2, fractional_Y);
        }

        private float falloff(float x1, float y1)
        {
            return (1f - (x1 * x1 * (3f - 2f * x1))) * (1f - (y1 * y1 * (3f - 2f * y1)));
        }

        private float fall_off_noise(float x, float y)
        {
            int integer_X = (int)x;
            float fractional_X = x - integer_X;
            int integer_Y = (int)y;
            float fractional_Y = y - integer_Y;
            int integer_X1 = integer_X + 1;
            int integer_Y1 = integer_Y + 1;

            //cnt_f ff = (x1, y1) => (2f - (float)(Math.Sqrt((x1 * x1 ) + (y1 * y1 )))); //PARABOLOID as default
            //  cnt_f falloff = (x1, y1) => (1 - (x1 * x1 * (3 - 2 * x1))) * (1 - (y1 * y1 * (3 - 2 * y1)));
            //cnt_f1D ff = (t) => (t * t * t * (t * (t * 6 - 15) + 10)); //PARABOLOID as default
            return (noise(integer_X, integer_Y) * falloff(fractional_X, fractional_Y)
                + noise(integer_X1, integer_Y) * falloff(1 - fractional_X, fractional_Y)
                + noise(integer_X1, integer_Y1) * falloff(1 - fractional_X, 1 - fractional_Y)
                + noise(integer_X, integer_Y1) * falloff(fractional_X, 1 - fractional_Y)
                );

        }

        public double PerlinNoise2d(int x, int y, float x_frequency, float y_frequency, float persistence, float octaves, float amplitude)
        {
            double total = 0.0;
            for (int lcv = 0; lcv < octaves; lcv++)
            {
                if (fastPerlin)
                    total = total + fast_InterpolatedNoise_1(x * x_frequency, y * y_frequency) * amplitude;
                else
                    if (falloffPerlin)
                        total = total + fall_off_noise(x * x_frequency, y * y_frequency) * amplitude;
                    else
                        total = total + InterpolatedNoise_1(x * x_frequency, y * y_frequency) * amplitude;

                //total = total + noise(x * x_frequency, y * y_frequency, (float)W * x_frequency, (float)H * y_frequency) * amplitude;
                //total = total + SmoothNoise_1(x * x_frequency, y * y_frequency, (float)W * x_frequency, (float)H * y_frequency) * amplitude;

                if (total > 1)
                    break;
                x_frequency = x_frequency * 2f;
                y_frequency = y_frequency * 2f;
                amplitude = amplitude * persistence;
            }
            // double cloudCoverage = 0.0; // USER ADJUSTABLE
            // double cloudDensity = 1.0; // USER ADJUSTABLE
            total = (total - cloudCoverage) * cloudDensity;
            if (total < 0)
                total = 0.0;
            if (total > 1)
                total = 1.0; //black
            return total;
        }




        #region functionPipeMngmnt
        private bool useFuncPipe = false;
        List<cnt_f1D> fPipe = new List<cnt_f1D>();

        private void addFunc(cnt_f1D f)
        {
            fPipe.Add(f);
        }
        #endregion

        public float getV(int x , int y, float x_frequency, float y_frequency, float persistence, float octaves, float amplitude)
        {
            if (fPipe.Count <= 0)
                return 0f;
            float v = (float)PerlinNoise2d(x, y,  x_frequency,  y_frequency,  persistence,  octaves,  amplitude);
            foreach (cnt_f1D ff in fPipe)
            {
                v = ff(v);
            }
            return v;
        }



        #region value Functions


        public void Wave(float wf, float amp)
        {
            //                        Values[i, j] = Values[i, j] + (float)Math.Sin(Values[i, j] * wf) * amp;
            cnt_f1D f = (x) => x + (float)Math.Sin(x * 255 * wf) * amp;
            addFunc(f); //add to pipe .. needs commit
            return;
        }

        public void Cartoon(float V)
        {
            if (V == 0)
                V = 0.001f;
            //                        Values[i, j] = Values[i, j] + (float)Math.Sin(Values[i, j] * wf) * amp;
            cnt_f1D f = (x) => (x) - x % V;
            addFunc(f); //add to pipe .. needs commit
            return;
        }

        public void SetRange(float fromV, float toV, float newV)
        {
            cnt_f1D f = (x) => (x <= toV && x >= fromV) ? newV : x;

                addFunc(f); //add to pipe .. needs commit
            return;
        }


        //random noise per pixel
        public void pixelNoise(double delta, int positive)
        {

            if (positive == 0)
            {
                cnt_f1D f = (x) => clamp(x + (float)(r.NextDouble() * (2 * delta) - delta), 0f, 1f);

                    addFunc(f); //add to pipe .. needs commit
            }
            else
            {
                cnt_f1D f = (x) => x + (float)(r.NextDouble() * (delta));
                    addFunc(f); //add to pipe .. needs commit
            }
            return;
        }

        //random noise per pixel
        public void pixelRangeNoise(double delta, int positive, float fromV, float toV)
        {


            if (positive == 0)
            {
                cnt_f1D f = (x) => (x <= toV && x >= fromV) ?
                    x + (float)(r.NextDouble() * (2 * delta) - delta)
                    : x
                    ;
                    addFunc(f); //add to pipe .. needs commit
            }
            else
            {
                cnt_f1D f = (x) => (x <= toV && x >= fromV) ?
                    x + (float)(r.NextDouble() * (delta))
                    : x
                    ;


                    addFunc(f); //add to pipe .. needs commit
            }
            return;
        }


        public void Mod(float V)
        {
            cnt_f1D f = (x) => x % V;
                addFunc(f); //add to pipe .. needs commit
        }

        public void And(float V)
        {
            cnt_f1D f = (x) => (int)(x * 255) & (int)(V * 255);

                addFunc(f); //add to pipe .. needs commit
        }

        public void Cut(float CutValue)
        {
            cnt_f1D f = (x) => (x < CutValue) ? x : CutValue;  //landscape 2  
                addFunc(f); //add to pipe .. needs commit
        }


        public void Invert()
        {
            cnt_f1D f = (x) => 1f - x;  //!!!!
                addFunc(f); //add to pipe .. needs commit
        }

        //public void Flat(float level , float softVal)
        public void FlatLog(float level)
        {
            cnt_f1D f = (x) => x - (float)Math.Log(1 + Math.Abs(x - level)) * Math.Sign(x - level);
                addFunc(f); //add to pipe .. needs commit
        }


        public void addContrast(float V)
        {
            cnt_f1D f = (x) => ((((x) - 0.5f) * V) + 0.5f);
            addFunc(f);
        }


        public void Flat(float level, float smoth)
        {
            smoth = clamp(smoth, 0, 1);
            cnt_f1D f = (x) => x - (x - level) * smoth;
                addFunc(f); //add to pipe .. needs commit
        }


        //http://blog.demofox.org/2012/09/24/bias-and-gain-are-your-friend/
        private float GetBias(float time, float bias)
        {
            return (time / ((((1f / bias) - 2f) * (1f - time)) + 1f));
        }
        private float GetGain(float time, float gain)
        {
            if (time < 0.5f)
                return GetBias(time * 2f, gain) / 2f;
            else
                return GetBias(time * 2f - 1f, 1f - gain) / 2f + 0.5f;
        }

        public void Bias(float bias, float maxv)
        {
            if (maxv > 0 && bias > 0)//avoiding division by zero
            {
                cnt_f1D f = (x) => GetBias((x / maxv), bias) * maxv;
                    addFunc(f); //add to pipe .. needs commit
            }
        }

        public void Gain(float gain, float maxv)
        {
            if (maxv > 0 && gain > 0)//avoiding division by zero
            {
                cnt_f1D f = (x) => GetGain((x / maxv), gain) * maxv;
                    addFunc(f); //add to pipe .. needs commit
            }
        }


        public void MulV(float V)
        {
            cnt_f1D f = (x) => x * V;
                addFunc(f); //add to pipe .. needs commit
        }

        public void Landscape(float seaLevel)
        {
            cnt_f1D f = (x) => (x < seaLevel) ? 0 : (x - seaLevel);  //landscape 2  
                addFunc(f); //add to pipe .. needs commit
        }



        public void Enance(float fromV, float toV)
        {
            cnt_f1D f = (x) => (x < fromV) ? 0 : (x > toV) ? 0 : x;
                addFunc(f); //add to pipe .. needs commit
        }

        public void EnanceB(float fromV, float toV)
        {
            cnt_f1D f = (x) => (x < fromV) ? 0 : (x > toV) ? 0 : 1f; //!!!!
                addFunc(f); //add to pipe .. needs commit
        }

        public void EnanceBorder(float fromV, float toV)
        {
            cnt_f1D f = (x) => (x < fromV) ? x * 0.7f : (x > toV) ? 0 : toV + x * 0.7f;
                addFunc(f); //add to pipe .. needs commit
        }

        public void EnanceS(float fromV, float toV)
        {
            cnt_f1D f = (x) => (x < fromV) ? x * 0.5f : (x > toV) ? toV + (x - toV) * 0.5f : x;
                addFunc(f); //add to pipe .. needs commit
        }

        public void EnanceS1(float fromV, float toV)
        {
            cnt_f1D f = (x) => (x < fromV) ? x * 0.5f : (x > toV) ? x * 0.5f : x;
                addFunc(f); //add to pipe .. needs commit
        }

        public void EnanceS2(float fromV, float toV)
        {
            cnt_f1D f = (x) => (x < fromV) ? x * 0.5f : (x > toV) ? 1f - x * 0.5f : x; //!!!!
                addFunc(f); //add to pipe .. needs commit
        }


    
#endregion    
    
    }







    }

