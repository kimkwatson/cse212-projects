using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Create a queue with the following item and priority: item(1)
    // Expected Result: item(1)
    // Defect(s) Found: 
    public void TestPriorityQueue_1()
    {
        var testItems = new PriorityQueue();
        var test = new PriorityItem("item", 1);
        testItems.Enqueue(test.Value, test.Priority);
        var testOutput = testItems.Dequeue();
        Assert.IsInstanceOfType(testOutput, typeof(PriorityItem), "The enqueued item must be a PriorityItem.");
    }

    [TestMethod]
    // Scenario: Create a queue with the following to-do items and priorities: breakfast(2), shower(2), shopping(1), homework(3)
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        var homework = new PriorityItem("homework", 3);
        var shower = new PriorityItem("shower", 2);
        var scriptures = new PriorityItem("scriptures", 4);
        var emails = new PriorityItem("emails", 1);
        
        PriorityItem[] expectedResult = { scriptures, homework, shower, emails };
        
        var todoList = new PriorityQueue();
        todoList.Enqueue(homework.Value, homework.Priority);
        todoList.Enqueue(shower.Value, shower.Priority);
        todoList.Enqueue(scriptures.Value, scriptures.Priority);
        todoList.Enqueue(emails.Value, emails.Priority);

        int i = 0;
        while (todoList.Count > 0)
        {
            if (i >= expectedResult.Length)
            {
                Assert.Fail("Queue should have run out of items by now.");
            }

           var item = todoList.Dequeue();
            Assert.AreEqual(expectedResult[i].Value, item.Value);
            i++;
        }
    }
    }

    // Add more test cases as needed below.
}