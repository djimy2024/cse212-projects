using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        //Assert.Fail("Implement the test case and then remove this.");
        priorityQueue.Enqueue("Low", 2);
        priorityQueue.Enqueue("High", 5);
        priorityQueue.Enqueue("Medium", 3);

        Assert.AreEqual("High", priorityQueue.Dequeue());   // Priority 5
        Assert.AreEqual("Medium", priorityQueue.Dequeue()); // Priority 3
        Assert.AreEqual("Low", priorityQueue.Dequeue());    // Priority 2
    }

    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        //Assert.Fail("Implement the test case and then remove this.");
        priorityQueue.Enqueue("First", 4);
        priorityQueue.Enqueue("Second", 4);
        priorityQueue.Enqueue("Third", 2);

        Assert.AreEqual("First", priorityQueue.Dequeue());  // Priority 4
        Assert.AreEqual("Second", priorityQueue.Dequeue()); // Priority 4
        Assert.AreEqual("Third", priorityQueue.Dequeue());  // Priority 2
    }

    // Add more test cases as needed below.
    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_3()
    {
    var priorityQueue = new PriorityQueue();
    //Assert.Fail("Implement the test case and then remove this.");
    priorityQueue.Enqueue("One", 5);
    priorityQueue.Enqueue("Two", 4);
    priorityQueue.Enqueue("Three", 3);
    priorityQueue.Enqueue("Four", 2);
    priorityQueue.Enqueue("Five", 1);

    Assert.AreEqual("One", priorityQueue.Dequeue());// Priority 5
    Assert.AreEqual("Two", priorityQueue.Dequeue());// Priority 4
    Assert.AreEqual("Three", priorityQueue.Dequeue());// Priority 3
    Assert.AreEqual("Four", priorityQueue.Dequeue());// Priority 2
    Assert.AreEqual("Five", priorityQueue.Dequeue());// Priority 1
    }

}