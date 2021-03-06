using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    static class Utility
    {
        public static string[] Renders =
        {
	        #region Frames
	        // 0
	        @"      ╔═══╗   " + '\n' +
            @"      |   ║   " + '\n' +
            @"          ║   " + '\n' +
            @"          ║   " + '\n' +
            @"          ║   " + '\n' +
            @"     ███  ║   " + '\n' +
            @"    ══════╩═══",
	        // 1
	        @"      ╔═══╗   " + '\n' +
            @"      |   ║   " + '\n' +
            @"      O   ║   " + '\n' +
            @"          ║   " + '\n' +
            @"          ║   " + '\n' +
            @"     ███  ║   " + '\n' +
            @"    ══════╩═══",
	        // 2
	        @"      ╔═══╗   " + '\n' +
            @"      |   ║   " + '\n' +
            @"      O   ║   " + '\n' +
            @"      |   ║   " + '\n' +
            @"          ║   " + '\n' +
            @"     ███  ║   " + '\n' +
            @"    ══════╩═══",
	        // 3
	        @"      ╔═══╗   " + '\n' +
            @"      |   ║   " + '\n' +
            @"      O   ║   " + '\n' +
            @"      |\  ║   " + '\n' +
            @"          ║   " + '\n' +
            @"     ███  ║   " + '\n' +
            @"    ══════╩═══",
	        // 4
	        @"      ╔═══╗   " + '\n' +
            @"      |   ║   " + '\n' +
            @"      O   ║   " + '\n' +
            @"     /|\  ║   " + '\n' +
            @"          ║   " + '\n' +
            @"     ███  ║   " + '\n' +
            @"    ══════╩═══",
	        // 5
	        @"      ╔═══╗   " + '\n' +
            @"      |   ║   " + '\n' +
            @"      O   ║   " + '\n' +
            @"     /|\  ║   " + '\n' +
            @"       \  ║   " + '\n' +
            @"     ███  ║   " + '\n' +
            @"    ══════╩═══",
	        // 6
	        @"      ╔═══╗   " + '\n' +
            @"      |   ║   " + '\n' +
            @"      O   ║   " + '\n' +
            @"     /|\  ║   " + '\n' +
            @"     / \  ║   " + '\n' +
            @"     ███  ║   " + '\n' +
            @"    ══════╩═══",
	        #endregion
        };

        public static string[] DeathAnimation =
        {
	        #region Frames
	        //
	        @"      ╔═══╗   " + '\n' +
            @"      |   ║   " + '\n' +
            @"      O   ║   " + '\n' +
            @"     /|\  ║   " + '\n' +
            @"     / \  ║   " + '\n' +
            @"     ███  ║   " + '\n' +
            @"    ══════╩═══",
	        //
	        @"      ╔═══╗   " + '\n' +
            @"      |   ║   " + '\n' +
            @"      O   ║   " + '\n' +
            @"     /|\  ║   " + '\n' +
            @"     / \  ║   " + '\n' +
            @"          ║   " + '\n' +
            @"    ══════╩═══",
	        //
	        @"      ╔═══╗   " + '\n' +
            @"      |   ║   " + '\n' +
            @"      o>  ║   " + '\n' +
            @"     /|   ║   " + '\n' +
            @"      >\  ║   " + '\n' +
            @"          ║   " + '\n' +
            @"    ══════╩═══",
	        //
	        @"      ╔═══╗   " + '\n' +
            @"      |   ║   " + '\n' +
            @"      O   ║   " + '\n' +
            @"     /|\  ║   " + '\n' +
            @"     / \  ║   " + '\n' +
            @"          ║   " + '\n' +
            @"    ══════╩═══",
	        //
	        @"      ╔═══╗   " + '\n' +
            @"      |   ║   " + '\n' +
            @"     <o   ║   " + '\n' +
            @"      |\  ║   " + '\n' +
            @"     /<   ║   " + '\n' +
            @"          ║   " + '\n' +
            @"    ══════╩═══",
	        //
	        @"      ╔═══╗   " + '\n' +
            @"      |   ║   " + '\n' +
            @"      O   ║   " + '\n' +
            @"     /|\  ║   " + '\n' +
            @"     / \  ║   " + '\n' +
            @"          ║   " + '\n' +
            @"    ══════╩═══",
	        //
	        @"      ╔═══╗   " + '\n' +
            @"      |   ║   " + '\n' +
            @"      o>  ║   " + '\n' +
            @"     /|   ║   " + '\n' +
            @"      >\  ║   " + '\n' +
            @"          ║   " + '\n' +
            @"    ══════╩═══",
	        //
	        @"      ╔═══╗   " + '\n' +
            @"      |   ║   " + '\n' +
            @"      o>  ║   " + '\n' +
            @"     /|   ║   " + '\n' +
            @"      >\  ║   " + '\n' +
            @"          ║   " + '\n' +
            @"    ══════╩═══",
	        //
	        @"      ╔═══╗   " + '\n' +
            @"      |   ║   " + '\n' +
            @"      O   ║   " + '\n' +
            @"     /|\  ║   " + '\n' +
            @"     / \  ║   " + '\n' +
            @"          ║   " + '\n' +
            @"    ══════╩═══",
	        //
	        @"      ╔═══╗   " + '\n' +
            @"      |   ║   " + '\n' +
            @"     <o   ║   " + '\n' +
            @"      |\  ║   " + '\n' +
            @"     /<   ║   " + '\n' +
            @"          ║   " + '\n' +
            @"    ══════╩═══",
	        //
	        @"      ╔═══╗   " + '\n' +
            @"      |   ║   " + '\n' +
            @"     <o   ║   " + '\n' +
            @"      |\  ║   " + '\n' +
            @"     /<   ║   " + '\n' +
            @"          ║   " + '\n' +
            @"    ══════╩═══",
	        //
	        @"      ╔═══╗   " + '\n' +
            @"      |   ║   " + '\n' +
            @"     <o   ║   " + '\n' +
            @"      |\  ║   " + '\n' +
            @"     /<   ║   " + '\n' +
            @"          ║   " + '\n' +
            @"    ══════╩═══",
	        //
	        @"      ╔═══╗   " + '\n' +
            @"      |   ║   " + '\n' +
            @"      O   ║   " + '\n' +
            @"     /|\  ║   " + '\n' +
            @"     / \  ║   " + '\n' +
            @"          ║   " + '\n' +
            @"    ══════╩═══",
	        //
	        @"      ╔═══╗   " + '\n' +
            @"      |   ║   " + '\n' +
            @"      o   ║   " + '\n' +
            @"      |   ║   " + '\n' +
            @"      |   ║   " + '\n' +
            @"          ║   " + '\n' +
            @"    ══════╩═══",
	        //
	        @"      ╔═══╗   " + '\n' +
            @"      |   ║   " + '\n' +
            @"      o   ║   " + '\n' +
            @"      |   ║   " + '\n' +
            @"      |   ║   " + '\n' +
            @"          ║   " + '\n' +
            @"    ══════╩═══",
	        //
	        @"      ╔═══╗   " + '\n' +
            @"      |   ║   " + '\n' +
            @"      o   ║   " + '\n' +
            @"      |   ║   " + '\n' +
            @"      |   ║   " + '\n' +
            @"          ║   " + '\n' +
            @"    ══════╩═══",
	        //
	        @"      ╔═══╗   " + '\n' +
            @"      |   ║   " + '\n' +
            @"      o   ║   " + '\n' +
            @"      |   ║   " + '\n' +
            @"      |   ║   " + '\n' +
            @"          ║   " + '\n' +
            @"    ══════╩═══",
	        //
	        @"      ╔═══╗   " + '\n' +
            @"      |   ║   " + '\n' +
            @"      o   ║   " + '\n' +
            @"      |   ║   " + '\n' +
            @"      |   ║   " + '\n' +
            @"          ║   " + '\n' +
            @"    ══════╩═══",
	        //
	        @"      ╔═══╗   " + '\n' +
            @"      |   ║   " + '\n' +
            @"      o   ║   " + '\n' +
            @"      |   ║   " + '\n' +
            @"      |   ║   " + '\n' +
            @"          ║   " + '\n' +
            @"    ══════╩═══",
	        //
	        @"      ╔═══╗   " + '\n' +
            @"      |   ║   " + '\n' +
            @"      O   ║   " + '\n' +
            @"          ║   " + '\n' +
            @"      |   ║   " + '\n' +
            @"      |   ║   " + '\n' +
            @"    ══════╩═══",
	        //
	        @"      ╔═══╗   " + '\n' +
            @"      |   ║   " + '\n' +
            @"      O   ║   " + '\n' +
            @"          ║   " + '\n' +
            @"      /   ║   " + '\n' +
            @"      \   ║   " + '\n' +
            @"    ══════╩═══",
	        //
	        @"      ╔═══╗   " + '\n' +
            @"      |   ║   " + '\n' +
            @"      O   ║   " + '\n' +
            @"      '   ║   " + '\n' +
            @"          ║   " + '\n' +
            @"    |__   ║   " + '\n' +
            @"    ══════╩═══",
	        //
	        @"      ╔═══╗   " + '\n' +
            @"      |   ║   " + '\n' +
            @"      O   ║   " + '\n' +
            @"      .   ║   " + '\n' +
            @"          ║   " + '\n' +
            @"    \__   ║   " + '\n' +
            @"    ══════╩═══",
	        //
	        @"      ╔═══╗   " + '\n' +
            @"      |   ║   " + '\n' +
            @"      O   ║   " + '\n' +
            @"          ║   " + '\n' +
            @"      '   ║   " + '\n' +
            @"   ____   ║   " + '\n' +
            @"    ══════╩═══",
	        //
	        @"      ╔═══╗   " + '\n' +
            @"      |   ║   " + '\n' +
            @"      O   ║   " + '\n' +
            @"      '   ║   " + '\n' +
            @"      .   ║   " + '\n' +
            @"    __    ║   " + '\n' +
            @"   /══════╩═══",
	        //
	        @"      ╔═══╗   " + '\n' +
            @"      |   ║   " + '\n' +
            @"      O   ║   " + '\n' +
            @"      .   ║   " + '\n' +
            @"          ║   " + '\n' +
            @"    _ '   ║   " + '\n' +
            @"  _/══════╩═══",
	        //
	        @"      ╔═══╗   " + '\n' +
            @"      |   ║   " + '\n' +
            @"      O   ║   " + '\n' +
            @"          ║   " + '\n' +
            @"      '   ║   " + '\n' +
            @"      _   ║   " + '\n' +
            @" __/══════╩═══",
	        //
	        @"      ╔═══╗   " + '\n' +
            @"      |   ║   " + '\n' +
            @"      O   ║   " + '\n' +
            @"      '   ║   " + '\n' +
            @"      .   ║   " + '\n' +
            @"          ║   " + '\n' +
            @" __/══════╩═══",
	        //
	        @"      ╔═══╗   " + '\n' +
            @"      |   ║   " + '\n' +
            @"      O   ║   " + '\n' +
            @"      .   ║   " + '\n' +
            @"          ║   " + '\n' +
            @"      '   ║   " + '\n' +
            @" __/══════╩═══",
	        //
	        @"      ╔═══╗   " + '\n' +
            @"      |   ║   " + '\n' +
            @"      O   ║   " + '\n' +
            @"          ║   " + '\n' +
            @"      '   ║   " + '\n' +
            @"      _   ║   " + '\n' +
            @" __/══════╩═══",
	        //
	        @"      ╔═══╗   " + '\n' +
            @"      |   ║   " + '\n' +
            @"      O   ║   " + '\n' +
            @"      '   ║   " + '\n' +
            @"      .   ║   " + '\n' +
            @"          ║   " + '\n' +
            @" __/══════╩═══",
	        //
	        @"      ╔═══╗   " + '\n' +
            @"      |   ║   " + '\n' +
            @"      O   ║   " + '\n' +
            @"      .   ║   " + '\n' +
            @"          ║   " + '\n' +
            @"      '   ║   " + '\n' +
            @" __/══════╩═══",
	        //
	        @"      ╔═══╗   " + '\n' +
            @"      |   ║   " + '\n' +
            @"      O   ║   " + '\n' +
            @"          ║   " + '\n' +
            @"      '   ║   " + '\n' +
            @"      _   ║   " + '\n' +
            @" __/══════╩═══",
	        //
	        @"      ╔═══╗   " + '\n' +
            @"      |   ║   " + '\n' +
            @"      O   ║   " + '\n' +
            @"          ║   " + '\n' +
            @"      .   ║   " + '\n' +
            @"          ║   " + '\n' +
            @" __/══════╩═══",
	        //
	        @"      ╔═══╗   " + '\n' +
            @"      |   ║   " + '\n' +
            @"      O   ║   " + '\n' +
            @"          ║   " + '\n' +
            @"          ║   " + '\n' +
            @"      '   ║   " + '\n' +
            @" __/══════╩═══",
	        //
	        @"      ╔═══╗   " + '\n' +
            @"      |   ║   " + '\n' +
            @"      O   ║   " + '\n' +
            @"          ║   " + '\n' +
            @"          ║   " + '\n' +
            @"      _   ║   " + '\n' +
            @" __/══════╩═══",
	        #endregion
        };

        public static string ChooseRandom(string[] values)
        {
            Random random = new Random();
            return values[random.Next(values.Length)];
        }
        public static T ChooseRandom<T>(T[] values)
        {
            Random random = new Random();
            return values[random.Next(values.Length)];
        }
    }
}
