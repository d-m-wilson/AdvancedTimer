using System;
using System.Timers;
using AdvancedTimer.Forms.Plugin.Abstractions;
using Xamarin.Forms;

namespace AdvancedTimer.Forms.Plugin.iOS
{
    /// <summary>
    /// AdvancedTimer Implementation
    /// </summary>
    [Foundation.Preserve(AllMembers = true, Conditional = false)]
    public class AdvancedTimerImplementation : IAdvancedTimer
    {
        Timer timer;
        int interval;
        bool autoReset;

        /// <summary>
        /// Used for registration with dependency service
        /// </summary>
        public static void Init()
        {
            DependencyService.Register<IAdvancedTimer, AdvancedTimerImplementation>();
        }

        /// <summary>
        /// Used for initializing timer and options
        /// </summary>
        public void InitTimer(int interval, EventHandler e, bool autoReset)
        {
            if (this.timer == null)
            {
                this.timer = new Timer(interval);
                this.timer.Elapsed += new ElapsedEventHandler(e);
            }

            this.interval = interval;
            this.autoReset = autoReset;

            this.timer.AutoReset = autoReset;
        }

        /// <summary>
        /// Used for starting timer
        /// </summary>
        public void StartTimer()
        {
            if (this.timer != null)
            {
                if (!this.timer.Enabled)
                {
                    this.timer.Start();
                }
            }
            else
            {
                throw new NullReferenceException("Timer not initialized. You should call initTimer function first!");
            }
        }

        /// <summary>
        /// Used for stopping timer
        /// </summary>
        public void StopTimer()
        {
            if (this.timer != null)
            {
                if (this.timer.Enabled)
                {
                    this.timer.Stop();
                }
            }
            else
            {
                throw new NullReferenceException("Timer not initialized. You should call initTimer function first!");
            }
        }

        /// <summary>
        /// Used for checking timer status
        /// </summary>
        public bool IsTimerEnabled
        {
			get 
			{
				return this.timer.Enabled;
			}
        }

        /// <summary>
        /// Used for checking timer interval
        /// </summary>
        public int Interval
        {
			get 
			{
				return this.interval;
			}
			set 
			{
				this.interval = value;
				this.timer.Interval = value;
			}
        }

    }
}