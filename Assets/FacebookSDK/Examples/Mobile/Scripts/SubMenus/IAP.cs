/**
 * Copyright (c) 2014-present, Facebook, Inc. All rights reserved.
 *
 * You are hereby granted a non-exclusive, worldwide, royalty-free license to use,
 * copy, modify, and distribute this software in source code or binary form for use
 * in connection with the web services and APIs provided by Facebook.
 *
 * As with any software that integrates with the Facebook platform, your use of
 * this software is subject to the Facebook Developer Principles and Policies
 * [http://developers.facebook.com/policy/]. This copyright notice shall be
 * included in all copies or substantial portions of the software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS
 * FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR
 * COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER
 * IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN
 * CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
 */

namespace Facebook.Unity.Example
{
    using System.Collections.Generic;

    internal class IAP : MenuBase
    {
        protected override void GetGui()
        {
#if UNITY_IOS
            if (this.Button("Initialize SK1"))
            {
                this.Status = "Initialized SK1";
                IAPWrapper.InitializeSK1();
                LogView.AddLog(
                    "Initialized SK1");
            }
            if (this.Button("Initialize SK2"))
            {
                this.Status = "Initialized SK2";
                IAPWrapper.InitializeSK2();
                LogView.AddLog(
                    "Initialized SK2");
            }
#elif UNITY_ANDROID
            if (this.Button("Initialize GPBL"))
            {
                this.Status = "Initialized GPBL";
            //    IAPWrapper.InitializeGPBL();
                LogView.AddLog(
                    "Initialized GPBL");
            }
#else
            // Other Platforms not supported
#endif
            if (this.Button("Purchase IAP Consumable"))
            {
                this.Status = "Purchased IAP Consumable";
            //    IAPWrapper.PurchaseConsumable();
                LogView.AddLog(
                    "Purchased IAP Consumable");
            }
            if (this.Button("Purchase IAP Non-Consumable"))
            {
                this.Status = "Purchased IAP Non-Consumable";
            //    IAPWrapper.PurchaseNonConsumable();
                LogView.AddLog(
                    "Purchased IAP Non-Consumable");
            }
            if (this.Button("Purchase IAP Subscription"))
            {
                this.Status = "Purchased IAP Subscription";
            //    IAPWrapper.PurchaseSubscription();
                LogView.AddLog(
                    "Purchased IAP Subscription");
            }
        }
    }
}
