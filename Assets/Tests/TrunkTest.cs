using NUnit.Framework;
using UnityEngine;

public class TrunkTest {

    private readonly Color32 colorWithPackage = new Color32(236, 26, 212, 255);
    private readonly Color32 colorWithoutPackage = new Color(255, 255, 255, 255);

    [Test]
    public void TestColorAfterInitializing() {
        var trunk = new Trunk(colorWithPackage, colorWithoutPackage);
        var color = trunk.getColor();

        Assert.AreEqual(colorWithoutPackage, color);
    }

    [Test]
    public void TestCanPickupPackageAfterInitializing() {
        var trunk = new Trunk(colorWithPackage, colorWithoutPackage);
        var canPickUp = trunk.canPickUpPackage();

        Assert.IsTrue(canPickUp);
    }

    [Test]
    public void TestCanDeliverPackageAfterInitializing() {
        var trunk = new Trunk(colorWithPackage, colorWithoutPackage);
        var canDeliver = trunk.canDeliverPackage();

        Assert.IsFalse(canDeliver);
    }

    [Test]
    public void TestColorAfterPickUp() {
        var trunk = new Trunk(colorWithPackage, colorWithoutPackage);
        trunk.pickUpPackage();
        var color = trunk.getColor();

        Assert.AreEqual(colorWithPackage, color);
    }

    [Test]
    public void TestCanPickupPackageAfterPickUp() {
        var trunk = new Trunk(colorWithPackage, colorWithoutPackage);
        trunk.pickUpPackage();
        var canPickUp = trunk.canPickUpPackage();

        Assert.IsFalse(canPickUp);
    }

    [Test]
    public void TestCanDeliverPackageAfterPickUp() {
        var trunk = new Trunk(colorWithPackage, colorWithoutPackage);
        trunk.pickUpPackage();
        var canDeliver = trunk.canDeliverPackage();

        Assert.IsTrue(canDeliver);
    }

    [Test]
    public void TestColorAfterDeliver() {
        var trunk = new Trunk(colorWithPackage, colorWithoutPackage);
        trunk.deliverPackage();
        var color = trunk.getColor();

        Assert.AreEqual(colorWithoutPackage, color);
    }

    [Test]
    public void TestCanPickupPackageAfterDeliver() {
        var trunk = new Trunk(colorWithPackage, colorWithoutPackage);
        trunk.deliverPackage();
        var canPickUp = trunk.canPickUpPackage();

        Assert.IsTrue(canPickUp);
    }

    [Test]
    public void TestCanDeliverPackageAfterDeliver() {
        var trunk = new Trunk(colorWithPackage, colorWithoutPackage);
        trunk.deliverPackage();
        var canDeliver = trunk.canDeliverPackage();

        Assert.IsFalse(canDeliver);
    }
}
