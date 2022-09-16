using System;
using System.Collections.Generic;
using Xunit;

namespace Assignment1.Tests;

public class UnitTest2 {
    [Fact]
        public void SplitLine_given_empty_list()
        {
        //Given
        var input = new List<string>{};
        var expected = new List<string>{};
        //When
        var actual = RegExpr.SplitLine(input);
        //Then
        Assert.Equal(expected,actual);
        }

        [Fact]
        public void SplitLine_given_non_empty_list_returns()
        {
        //Given
        string[] input = {"this is a test", "this;is;a;test"};
        //when
        var actual = RegExpr.SplitLine(input);
        //Then
        Assert.Equal(new string[] {"this","is","a","test","this","is","a","test"},actual);
        }

        [Fact]
        public void Resolution_given_empty_list()
        {
        //Given
        var input = "";
        var expected = new List<(int,int)>();
        //When
        var actual = RegExpr.Resolution(input);
        //Then
        Assert.Equal(expected,actual);
        }

        [Fact]
        public void Resolution_given_list_with_resolutions()
        {
        //Given
        var input = "1920x1080 1024x768, 800x600, 640x480 320x200, 320x240, 800x600 1280x960";

        //When
        var actual = RegExpr.Resolution(input);
        //Then
        Assert.Equal(new (int,int)[] {(1920, 1080),(1024, 768),(800, 600),(640, 480),(320, 200),(320, 240),(800, 600),(1280, 960)},actual);
        }

        [Fact]
        public void Resolution_given_list_with_resolutions_and_words()
        {
        //Given
        var input = "1920x1080 1024x768, this 800x600, 640x480 is320x200, 320x240,  not 800x600 supposed to be here 1280x960";

        //When
        var actual = RegExpr.Resolution(input);
        //Then
        Assert.Equal(new (int,int)[] {(1920, 1080),(1024, 768),(800, 600),(640, 480),(320, 200),(320, 240),(800, 600),(1280, 960)},actual);
        }

        [Fact]
        public void InnerText_given_html_string()
        {
        //Given
        var input = "<div><p>A <b>regular expression</b>, <b>regex</b> or <b>regexp</b> (sometimes called a <b>rational expression</b>) is, in <a href=\"/wiki/Theoretical_computer_science\" title=\"Theoretical computer science\">theoretical computer science</a> and <a href=\"/wiki/Formal_language\" title=\"Formal language\">formal language</a> theory, a sequence of <a href=\"/wiki/Character_(computing)\" title=\"Character (computing)\">characters</a> that define a <i>search <a href=\"/wiki/Pattern_matching\" title=\"Pattern matching\">pattern</a></i>. Usually this pattern is then used by <a href=\"/wiki/String_searching_algorithm\" title=\"String searching algorithm\">string searching algorithms</a> for \"find\" or \"find and replace\" operations on <a href=\"/wiki/String_(computer_science)\" title=\"String (computer science)\">strings</a>.</p></div>";
        //When
        var actual = RegExpr.InnerText(input,"a");
        
        //Then
        Assert.Equal(new string[] {"theoretical computer science","formal language","characters","pattern","string searching algorithms","strings"} ,actual);
        }
}