using NUnit.Framework;
using UnityEditor;
using UnityEngine;

public class EngineTest {
    [Test]
    public void TestSteerSpeed() {
        var engine = new EngineManager.Engine(200f, 20f, 35f);
        Assert.AreEqual(200f, engine.getSteerSpeed());
    }

    [Test]
    public void TestMoveSpeedAfterInitializing() {
        var engine = new EngineManager.Engine(200f, 20f, 35f);
        Assert.AreEqual(20f, engine.getMoveSpeed());
    }

    [Test]
    public void TestMoveSpeedAfterSetBoosterToTrue() {
        var engine = new EngineManager.Engine(200f, 20f, 35f);
        engine.setBoosted(true);
        Assert.AreEqual(35f, engine.getMoveSpeed());
    }

    [Test]
    public void TestMoveSpeedAfterSetBoosterToFalse() {
        var engine = new EngineManager.Engine(200f, 20f, 35f);
        engine.setBoosted(false);
        Assert.AreEqual(20f, engine.getMoveSpeed());
    }
}    
