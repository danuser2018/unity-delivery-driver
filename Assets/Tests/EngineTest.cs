using NUnit.Framework;
using UnityEngine;

public class EngineTest {
    [Test]
    public void TestSteerSpeed() {
        var engine = new Engine(200f, 20f, 35f);
        Assert.AreEqual(200f, engine.getSteerSpeed());
    }

    [Test]
    public void TestMoveSpeedAfterInitializing() {
        var engine = new Engine(200f, 20f, 35f);
        Assert.AreEqual(20f, engine.getMoveSpeed());
    }

    [Test]
    public void TestMoveSpeedAfterActivateBoost() {
        var engine = new Engine(200f, 20f, 35f);
        engine.activateBoost();
        Assert.AreEqual(35f, engine.getMoveSpeed());
    }

    [Test]
    public void TestMoveSpeedAfterDeactivateBoost() {
        var engine = new Engine(200f, 20f, 35f);
        engine.deactivateBoost();
        Assert.AreEqual(20f, engine.getMoveSpeed());
    }
}    
