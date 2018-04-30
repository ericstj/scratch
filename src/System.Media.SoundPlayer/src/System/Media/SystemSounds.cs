// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.


namespace System.Media
{
    public sealed class SystemSounds
    {
        private static volatile SystemSound s_asterisk;
        private static volatile SystemSound s_beep;
        private static volatile SystemSound s_exclamation;
        private static volatile SystemSound s_hand;
        private static volatile SystemSound s_question;

        private SystemSounds()
        {
        }

        public static SystemSound Asterisk
        {
            get
            {
                if (s_asterisk == null)
                {
                    s_asterisk = new SystemSound(Interop.User32.MB_ICONASTERISK);
                }
                return s_asterisk;
            }
        }

        public static SystemSound Beep
        {
            get
            {
                if (s_beep == null)
                {
                    s_beep = new SystemSound(0);
                }
                return s_beep;
            }
        }

        public static SystemSound Exclamation
        {
            get
            {
                if (s_exclamation == null)
                {
                    s_exclamation = new SystemSound(Interop.User32.MB_ICONEXCLAMATION);
                }
                return s_exclamation;
            }
        }

        public static SystemSound Hand
        {
            get
            {
                if (s_hand == null)
                {
                    s_hand = new SystemSound(Interop.User32.MB_ICONHAND);
                }
                return s_hand;
            }
        }

        public static SystemSound Question
        {
            get
            {
                if (s_question == null)
                {
                    s_question = new SystemSound(Interop.User32.MB_ICONQUESTION);
                }
                return s_question;
            }
        }
    }

    public class SystemSound
    {
        private int _soundType;
        internal SystemSound(int soundType)
        {
            _soundType = soundType;
        }

        public void Play()
        {
            Interop.User32.MessageBeep(_soundType);
        }
    }
}
