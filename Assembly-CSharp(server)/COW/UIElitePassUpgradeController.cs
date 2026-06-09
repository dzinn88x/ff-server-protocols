using System;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x020017A6 RID: 6054
	[Token(Token = "0x20017A6")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F2864", Offset = "0x10F2864")]
	public class UIElitePassUpgradeController : UINavigationController
	{
		// Token: 0x0600739C RID: 29596 RVA: 0x00020190 File Offset: 0x0001E390
		[Token(Token = "0x600739C")]
		[Address(RVA = "0x1E70FFC", Offset = "0x1E70FFC", VA = "0x7BBC670FFC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600739D RID: 29597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600739D")]
		[Address(RVA = "0x1E7104C", Offset = "0x1E7104C", VA = "0x7BBC67104C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600739E RID: 29598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600739E")]
		[Address(RVA = "0x1E7241C", Offset = "0x1E7241C", VA = "0x7BBC67241C", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x0600739F RID: 29599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600739F")]
		[Address(RVA = "0x1E716B4", Offset = "0x1E716B4", VA = "0x7BBC6716B4")]
		private void InitRewards()
		{
		}

		// Token: 0x060073A0 RID: 29600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073A0")]
		[Address(RVA = "0x1E7253C", Offset = "0x1E7253C", VA = "0x7BBC67253C")]
		private void OnUpgradeClick()
		{
		}

		// Token: 0x060073A1 RID: 29601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073A1")]
		[Address(RVA = "0x1E72860", Offset = "0x1E72860", VA = "0x7BBC672860")]
		private void Purchase()
		{
		}

		// Token: 0x060073A2 RID: 29602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073A2")]
		[Address(RVA = "0x1E72964", Offset = "0x1E72964", VA = "0x7BBC672964")]
		private void OnBundleUpgrageClick()
		{
		}

		// Token: 0x060073A3 RID: 29603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073A3")]
		[Address(RVA = "0x1E72C88", Offset = "0x1E72C88", VA = "0x7BBC672C88")]
		private void PurchaseBundle()
		{
		}

		// Token: 0x060073A4 RID: 29604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073A4")]
		[Address(RVA = "0x1E713BC", Offset = "0x1E713BC", VA = "0x7BBC6713BC")]
		private void SetCDNTexture(params object[] data)
		{
		}

		// Token: 0x060073A5 RID: 29605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073A5")]
		[Address(RVA = "0x1E72D8C", Offset = "0x1E72D8C", VA = "0x7BBC672D8C")]
		private void OnAnimEvtOccur(params object[] data)
		{
		}

		// Token: 0x060073A6 RID: 29606 RVA: 0x000201A8 File Offset: 0x0001E3A8
		[Token(Token = "0x60073A6")]
		[Address(RVA = "0x1E72EA8", Offset = "0x1E72EA8", VA = "0x7BBC672EA8", Slot = "33")]
		public override EFrontendUIType GetBackgroundImageType()
		{
			return EFrontendUIType.Lobby;
		}

		// Token: 0x060073A7 RID: 29607 RVA: 0x000201C0 File Offset: 0x0001E3C0
		[Token(Token = "0x60073A7")]
		[Address(RVA = "0x1E72EB0", Offset = "0x1E72EB0", VA = "0x7BBC672EB0", Slot = "34")]
		public override AdType GetBackgroundCDNImageType()
		{
			return AdType.AdType_NONE;
		}

		// Token: 0x060073A8 RID: 29608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073A8")]
		[Address(RVA = "0x1E72EB8", Offset = "0x1E72EB8", VA = "0x7BBC672EB8")]
		private void OnRewardListCenter(GameObject centeredObject)
		{
		}

		// Token: 0x060073A9 RID: 29609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073A9")]
		[Address(RVA = "0x1E7305C", Offset = "0x1E7305C", VA = "0x7BBC67305C")]
		public UIElitePassUpgradeController()
		{
		}

		// Token: 0x04008BF0 RID: 35824
		[Token(Token = "0x4008BF0")]
		[FieldOffset(Offset = "0xB0")]
		private UIElitePassUpgradeView m_View;

		// Token: 0x04008BF1 RID: 35825
		[Token(Token = "0x4008BF1")]
		[FieldOffset(Offset = "0xB8")]
		private UIModelElitePass m_Model;

		// Token: 0x04008BF2 RID: 35826
		[Token(Token = "0x4008BF2")]
		[FieldOffset(Offset = "0xC0")]
		private uint totalRewardNum;

		// Token: 0x04008BF3 RID: 35827
		[Token(Token = "0x4008BF3")]
		[FieldOffset(Offset = "0xC8")]
		private EPPriceData m_Data;

		// Token: 0x020017A7 RID: 6055
		[Token(Token = "0x20017A7")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F289C", Offset = "0x10F289C")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060073AB RID: 29611 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60073AB")]
			[Address(RVA = "0x1E730D0", Offset = "0x1E730D0", VA = "0x7BBC6730D0")]
			public <>c()
			{
			}

			// Token: 0x060073AC RID: 29612 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60073AC")]
			[Address(RVA = "0x1E730D8", Offset = "0x1E730D8", VA = "0x7BBC6730D8")]
			internal void <OnUIInit>b__5_0()
			{
			}

			// Token: 0x060073AD RID: 29613 RVA: 0x000201D8 File Offset: 0x0001E3D8
			[Token(Token = "0x60073AD")]
			[Address(RVA = "0x1E73174", Offset = "0x1E73174", VA = "0x7BBC673174")]
			internal int <InitRewards>b__7_0(BaseItemInfo x, BaseItemInfo y)
			{
				return 0;
			}

			// Token: 0x060073AE RID: 29614 RVA: 0x000201F0 File Offset: 0x0001E3F0
			[Token(Token = "0x60073AE")]
			[Address(RVA = "0x1E731BC", Offset = "0x1E731BC", VA = "0x7BBC6731BC")]
			internal bool <SetCDNTexture>b__12_0(AdvertDesc x)
			{
				return default(bool);
			}

			// Token: 0x060073AF RID: 29615 RVA: 0x00020208 File Offset: 0x0001E408
			[Token(Token = "0x60073AF")]
			[Address(RVA = "0x1E731F0", Offset = "0x1E731F0", VA = "0x7BBC6731F0")]
			internal bool <SetCDNTexture>b__12_1(AdvertDesc x)
			{
				return default(bool);
			}

			// Token: 0x04008BF4 RID: 35828
			[Token(Token = "0x4008BF4")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIElitePassUpgradeController.<>c <>9;

			// Token: 0x04008BF5 RID: 35829
			[Token(Token = "0x4008BF5")]
			[FieldOffset(Offset = "0x8")]
			public static Action <>9__5_0;

			// Token: 0x04008BF6 RID: 35830
			[Token(Token = "0x4008BF6")]
			[FieldOffset(Offset = "0x10")]
			public static Comparison<BaseItemInfo> <>9__7_0;

			// Token: 0x04008BF7 RID: 35831
			[Token(Token = "0x4008BF7")]
			[FieldOffset(Offset = "0x18")]
			public static Predicate<AdvertDesc> <>9__12_0;

			// Token: 0x04008BF8 RID: 35832
			[Token(Token = "0x4008BF8")]
			[FieldOffset(Offset = "0x20")]
			public static Predicate<AdvertDesc> <>9__12_1;
		}
	}
}
