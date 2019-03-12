using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShwWeek3
{
    //单例模式实现
    class OnlyInstance
    {
        public static int count = 0;//记录实例个数
        private static class OnlyInstanceCreator
        {
            public static OnlyInstance onlyInstance = new OnlyInstance();
        }

        public static OnlyInstance GetInstance()
        {
            return OnlyInstanceCreator.onlyInstance;
        }

        public void ShowCount()
        {
            Console.WriteLine($"当前实例个数:{count}");
        }

        private OnlyInstance()
        {
            count++;
        }
    }

    //外观模式实现
    abstract class AbstractFacade
    {
        public abstract void Service();
    }

    class Facade:AbstractFacade
    {
        private A a = new A();
        private B b = new B();
        private C c = new C();

        public override void Service()
        {
            a.Service();
            b.Service();
            c.Service();
        }
    }

    class NewFacade : AbstractFacade
    {
        private A a = new A();
        private B b = new B();
        private D d = new D();

        public override void Service()
        {
            a.Service();
            b.Service();
            d.Service();
        }
    }

    class A
    {
        public void Service()
        {
            Console.WriteLine("提供服务A");
        }
    }
    class B
    {
        public void Service()
        {
            Console.WriteLine("提供服务B");
        }
    }
    class C
    {
        public void Service()
        {
            Console.WriteLine("提供服务C");
        }
    }
    class D
    {
        public void Service()
        {
            Console.WriteLine("提供服务D");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //单例模式实现检测
            Console.WriteLine("单例模式的实现：");
            OnlyInstance i1 = OnlyInstance.GetInstance();
            Console.WriteLine("OnlyInstance i1 = OnlyInstance.GetInstance();");
            OnlyInstance i2 = OnlyInstance.GetInstance();
            Console.WriteLine("OnlyInstance i2 = OnlyInstance.GetInstance();");
            Console.WriteLine($"当前OnlyInstance实例个数：{OnlyInstance.count}");
            bool isOnlyInstance = (i1 == i2) ? true : false;
            Console.WriteLine($"是否单例：{isOnlyInstance}");

            Console.WriteLine();

            //外观模式实现检测
            Console.WriteLine("外观模式的实现：");
            AbstractFacade facade = new Facade();
            Console.WriteLine("AbstractFacade facade = new Facade();");
            Console.WriteLine("facade.Service();");
            facade.Service();
            facade = new NewFacade();
            Console.WriteLine("AbstractFacade facade = new NewFacade();");
            Console.WriteLine("facade.Service();");
            facade.Service();
        }
    }
}
