using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Security.Permissions;

namespace System.Media {
    public sealed class SystemSounds {
        static volatile SystemSound asterisk;
        static volatile SystemSound beep;
        static volatile SystemSound exclamation;
        static volatile SystemSound hand;
        static volatile SystemSound question;

        private SystemSounds() {
        }

        public static SystemSound Asterisk {
            get {
                if (asterisk == null) {
                    asterisk = new SystemSound(Interop.User32.MB_ICONASTERISK);
                }
                return asterisk;
            }
        }

        public static SystemSound Beep {
            get {
                if (beep == null) {
                    beep = new SystemSound(0);
                }
                return beep;
            }
        }

        public static SystemSound Exclamation {
            get {
                if (exclamation == null) {
                    exclamation = new SystemSound(Interop.User32.MB_ICONEXCLAMATION);
                }
                return exclamation;
            }
        }

        public static SystemSound Hand {
            get {
                if (hand == null) {
                    hand = new SystemSound(Interop.User32.MB_ICONHAND);
                }
                return hand;
            }
        }

        public static SystemSound Question {
            get {
                if (question == null) {
                    question = new SystemSound(Interop.User32.MB_ICONQUESTION);
                }
                return question;
            }
        }
    }

    public class SystemSound {
        private int soundType;
        internal SystemSound(int soundType) {
            this.soundType = soundType;
        }

        public void Play() {
            Interop.User32.MessageBeep(soundType);
        }
    }
}
