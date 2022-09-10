using System;
using System.Collections.Generic;
using Xunit;

namespace Assignment1.Tests;

public class UnitTest1
{
[Fact]
public void Flatten_given_list_of_lists()
{
        // Given    
    var list = new List<List<int>>
    {
        new List<int> { 1, 2,3},
        new List<int> { 4, 5,6}
    };
    // When
    var result = Iterators.Flatten(list);
    // Then
    Assert.Equal(new[] {1,2,3,4,5,6}, result);
}
[Fact]
public void FilterEvens()
{
    // Given
    Predicate<int> evens = delegate(int x) {return (x % 2 == 0);};
    int[] list = {1,2,3,4,5,6,7,8};
    // When
    var filtered = Iterators.Filter(list,evens);
    // Then
    Assert.Equal(new[] {2,4,6,8}, filtered);
}
[Fact]
public void FilterOutWordDuck()
{
    // Given
    Predicate<string> isNotDuck = delegate(string x) {return x != "duck";};
    string[] list = {"there", "is","no","duck"};
    // When
    var filtered = Iterators.Filter(list,isNotDuck);
    // Then
    Assert.Equal(new [] {"there", "is","no"},filtered);
}

}