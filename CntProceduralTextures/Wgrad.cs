using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CntProceduralTextures
{

    public class gradObj<T>
    {
        public T ele { get; set; }
        public float w {get;set;}
        public gradObj(T e, float p)
        {
            ele = e;
            //clamp
            if (p > 1f)
                p = 1f;
            if (p < 0f)
                p = 0f;
            w = p;
        }        
    }

    public class Wgrad<T>
    {
        List<gradObj<T>> grad = new List<gradObj<T>>() ;

        public Wgrad(T startElE , T endEle){
            gradObj<T> start = new gradObj<T>(startElE, 0f);
            gradObj<T> end = new gradObj<T>(endEle, 1f);
            grad.Add(start);
            grad.Add(end);
        }

        static float Clamp01(float p) {
            if (p > 1f)
                return 1f;
            if (p < 0f)
                return 0f;
            return p;
        }

        public void UpdOrAddEle(T ele, float p, float tollerance)
        {
            if (tollerance > 0 && tollerance < 1)
            {
                int found = -1;
                for (int i = 0; i < grad.Count ; i++)
                {
                    float d = Math.Abs(p - grad[i].w);
                    if (d < tollerance)
                    {
                        found = i;
                    }
                }

                if (found > -1)
                {
                    grad[found].ele = ele;
                    return;
                }            
            }
            // if not found adds it:
            addEle(ele, p);   
        }

        public void addEle(T ele , float p){
            p = Clamp01(p);
            List<gradObj<T>> tmpgrad = new List<gradObj<T>>();
            bool added = false;
            foreach (gradObj<T> obj in grad) { 
                if (p < obj.w && !added){
                    tmpgrad.Add(new gradObj<T>(ele,p));
                    added = true;
                }
                tmpgrad.Add(obj);
            }
            grad = tmpgrad;
        }

        public gradObj<T> delNearest(float p) {
            gradObj<T> ret = null;
            float min = 1f;
            int found = -1;
            //jump first and last
            for (int i = 1; i < grad.Count - 1; i++)
            {
                float d = Math.Abs(p-grad[i].w);
                if (d < min ){
                    min = d;
                    found = i;
                }
            }
            if (found > -1) {
                ret = grad[found];
                grad.RemoveAt(found);
            }
            return ret;
        }

        public gradObj<T>[] getEle(float p) {
            p = Clamp01(p);
            gradObj<T>[] v = new gradObj<T>[2];
            if (p == 0f)
            {
                v[0] = grad[0];
                v[1] = grad[0];
                return v;
            }
            if (p == 1f)
            {
                v[0] = grad[grad.Count-1];
                v[1] = grad[grad.Count - 1];
                return v;
            }
            gradObj<T> precobj = null;
            foreach (gradObj<T> obj in grad)
            {
                if (p == obj.w)
                {
                    v[0] = obj;
                    v[1] = obj;
                    return v;
                }
                else {
                        if (p < obj.w) {
                            v[0] = precobj;
                            v[1] = obj;
                            return v;                            
                        }
                    }
                precobj = obj;
            }
            return v;
        }

        public gradObj<T>[] getArray()
        {
            return grad.ToArray();
        }

        public Wgrad<T> Clone() {
            Wgrad<T> tmp = new Wgrad<T>(this.grad[0].ele, this.grad[this.grad.Count - 1].ele);
            for (int i = 1; i < grad.Count - 1; i++)
            {
                tmp.addEle(grad[i].ele, grad[i].w);
            }
            return tmp;
        }

    }
}
