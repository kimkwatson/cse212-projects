using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Create a queue with the following to-do items and priorities: homework(3), shower(2), scriptures(4), emails(1) and run until the queue is empty.
    // Expected Result: scriptures, homework, shower, emails
    // Defect(s) Found: 
    public void TestPriorityQueue_1()
    {
        var homework = new PriorityItem("homework", 3);
        var shower = new PriorityItem("shower", 2);
        var scriptures = new PriorityItem("scriptures", 4);
        var emails = new PriorityItem("emails", 1);
        
        PriorityItem[] expectedResult = [scriptures, homework, shower, emails];
        
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue(homework.Value, homework.Priority);
        priorityQueue.Enqueue(shower.Value, shower.Priority);
        priorityQueue.Enqueue(scriptures.Value, scriptures.Priority);
        priorityQueue.Enqueue(emails.Value, emails.Priority);

        int i = 0;
        while (priorityQueue.Count > 0)
        {
            if (i >= expectedResult.Length)
            {
                Assert.Fail("Queue should have run out of items by now.");
            }

            var item = priorityQueue.Dequeue();
            Assert.AreEqual(expectedResult[i].Value, item.Value);
            i++;
        }
        Assert.Fail("Implement the test case and then remove this.");
    }

    [TestMethod]
    // Scenario: Create a queue with the following to-do items and priorities: breakfast(2), shower(2), shopping(1), homework(3)
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        Assert.Fail("Implement the test case and then remove this.");
    }

    // Add more test cases as needed below.
}