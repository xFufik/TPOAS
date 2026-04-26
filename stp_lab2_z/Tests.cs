using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

[TestClass]
public class EllipseTests
{
    [TestMethod]
    public void Area_CorrectValues()
    {
        // корректно ли вычисляется площадь эллипса
        Ellipse e = new Ellipse();
        e.Init(4, 2);
        Assert.AreEqual(Math.PI * 8, e.Area());
    }

    [TestMethod]
    public void Init_InvalidValues_DefaultSet()
    {
        // при некорректных значениях (a <= b) устанавливаются значения по умолчанию (2 и 1)
        Ellipse e = new Ellipse();
        e.Init(1, 5);
        Assert.AreEqual(Math.PI * 2, e.Area());
    }

    [TestMethod]
    public void PropertyB_ValidChange()
    {
        // свойство B корректно изменяет малую полуось при валидном значении
        Ellipse e = new Ellipse();
        e.Init(5, 2);
        e.B = 3;
        Assert.AreEqual(Math.PI * 15, e.Area());
    }

    [TestMethod]
    public void PropertyB_InvalidChange()
    {
        // при некорректном значении B (b >= a) устанавливается значение по умолчанию (b = 1)
        Ellipse e = new Ellipse();
        e.Init(5, 2);
        e.B = 10;
        Assert.AreEqual(Math.PI * 5, e.Area());
    }

    [TestMethod]
    public void Add_TwoEllipses()
    {
        // корректность сложения двух эллипсов (суммируются полуоси)
        Ellipse e1 = new Ellipse();
        e1.Init(4, 2);

        Ellipse e2 = new Ellipse();
        e2.Init(6, 3);

        Ellipse result = Ellipse.add(e1, e2);

        Assert.AreEqual(Math.PI * 50, result.Area());
    }

    [TestMethod]
    public void Add_ResultNotNull()
    {
        // результат сложения не равен null
        Ellipse e1 = new Ellipse();
        e1.Init(2, 1);

        Ellipse e2 = new Ellipse();
        e2.Init(3, 2);

        Assert.IsNotNull(Ellipse.add(e1, e2));
    }

    [TestMethod]
    public void Init_NegativeValues()
    {
        // при отрицательных значениях устанавливаются значения по умолчанию
        Ellipse e = new Ellipse();
        e.Init(-5, -1);
        Assert.AreEqual(Math.PI * 2, e.Area());
    }

    [TestMethod]
    public void Area_PositiveCheck()
    {
        // площадь эллипса всегда положительная при корректных данных
        Ellipse e = new Ellipse();
        e.Init(3, 1);
        Assert.IsTrue(e.Area() > 0);
    }

    [TestMethod]
    public void B_EqualsA_Invalid()
    {
        // если b == a (некорректно), устанавливается значение по умолчанию
        Ellipse e = new Ellipse();
        e.Init(5, 2);
        e.B = 5;
        Assert.AreEqual(Math.PI * 5, e.Area());
    }

    [TestMethod]
    public void Multiple_Add()
    {
        // корректность многократного сложения эллипсов
        Ellipse e1 = new Ellipse();
        e1.Init(2, 1);

        Ellipse e2 = new Ellipse();
        e2.Init(3, 2);

        Ellipse e3 = Ellipse.add(e1, e2);
        Ellipse e4 = Ellipse.add(e3, e1);

        Assert.IsNotNull(e4);
    }
}