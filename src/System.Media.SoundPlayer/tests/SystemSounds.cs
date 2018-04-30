// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using Xunit;

namespace System.Media.SoundPlayerTests
{
    public class SystemSoundsTests
    {
        public static IEnumerable<object[]> AllSystemSounds
        {
            get
            {
                yield return new object[] { new Func<SystemSound>(() => SystemSounds.Asterisk) };
                yield return new object[] { new Func<SystemSound>(() => SystemSounds.Beep) };
                yield return new object[] { new Func<SystemSound>(() => SystemSounds.Exclamation) };
                yield return new object[] { new Func<SystemSound>(() => SystemSounds.Hand) };
                yield return new object[] { new Func<SystemSound>(() => SystemSounds.Question) };
            }
        }

        [Theory(), MemberData(nameof(AllSystemSounds))]
        public void TestSystemSound(Func<SystemSound> getSystemSound)
        {
            var systemSound = getSystemSound();
            Assert.NotNull(systemSound);
          
            // singleton
            Assert.Same(systemSound, getSystemSound());

            systemSound.Play();
        }
    }
}
