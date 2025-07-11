using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Insert three elements with different priorities (2, 5, 3) and dequeue them.
    // Expected Result: Items are dequeued in order of priority: High (5), Medium (3), Low (2).
    // Defect(s) Found: Dequeue did not always return highest priority if not sorted or compared correctly.
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
    // Scenario: Insert elements with same priority and check if dequeue respects insertion order.
    // Expected Result: First, Second (both priority 4), then Third (priority 2).
    // Defect(s) Found: Priority ties did not maintain FIFO order initially.
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
    // Scenario: Enqueue five items with decreasing priorities and check full dequeue order.
    // Expected Result: Items returned in descending priority order from 5 to 1.
    // Defect(s) Found: Queue was not sorted or handled priority comparison properly.
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