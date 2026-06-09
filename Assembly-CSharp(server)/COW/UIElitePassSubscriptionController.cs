using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x020017A3 RID: 6051
	[Token(Token = "0x20017A3")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F27E4", Offset = "0x10F27E4")]
	public class UIElitePassSubscriptionController : UINavigationController, IUIModelDataChangeObserver
	{
		// Token: 0x06007384 RID: 29572 RVA: 0x00020130 File Offset: 0x0001E330
		[Token(Token = "0x6007384")]
		[Address(RVA = "0x1E6F528", Offset = "0x1E6F528", VA = "0x7BBC66F528")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007385 RID: 29573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007385")]
		[Address(RVA = "0x1E6F578", Offset = "0x1E6F578", VA = "0x7BBC66F578", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007386 RID: 29574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007386")]
		[Address(RVA = "0x1E6FEE0", Offset = "0x1E6FEE0", VA = "0x7BBC66FEE0", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06007387 RID: 29575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007387")]
		[Address(RVA = "0x1E6FA6C", Offset = "0x1E6FA6C", VA = "0x7BBC66FA6C")]
		private void UpdateCDNImage()
		{
		}

		// Token: 0x06007388 RID: 29576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007388")]
		[Address(RVA = "0x1E6FC58", Offset = "0x1E6FC58", VA = "0x7BBC66FC58")]
		private void UpdateSubscriptionProductInfo()
		{
		}

		// Token: 0x06007389 RID: 29577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007389")]
		[Address(RVA = "0x1E6FD4C", Offset = "0x1E6FD4C", VA = "0x7BBC66FD4C")]
		private void UpdateSubscriptionBonus()
		{
		}

		// Token: 0x0600738A RID: 29578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600738A")]
		[Address(RVA = "0x1E700E0", Offset = "0x1E700E0", VA = "0x7BBC6700E0")]
		private void OnSubscribeBtnClick()
		{
		}

		// Token: 0x0600738B RID: 29579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600738B")]
		[Address(RVA = "0x1E70180", Offset = "0x1E70180", VA = "0x7BBC670180")]
		private void OnSubscribeTipsBtnClick()
		{
		}

		// Token: 0x0600738C RID: 29580 RVA: 0x00020148 File Offset: 0x0001E348
		[Token(Token = "0x600738C")]
		[Address(RVA = "0x1E70218", Offset = "0x1E70218", VA = "0x7BBC670218", Slot = "40")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x0600738D RID: 29581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600738D")]
		[Address(RVA = "0x1E7025C", Offset = "0x1E7025C", VA = "0x7BBC67025C", Slot = "39")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x0600738E RID: 29582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600738E")]
		[Address(RVA = "0x1E70354", Offset = "0x1E70354", VA = "0x7BBC670354")]
		private void OnBtnTermsOfServiceClick()
		{
		}

		// Token: 0x0600738F RID: 29583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600738F")]
		[Address(RVA = "0x1E7035C", Offset = "0x1E7035C", VA = "0x7BBC67035C")]
		private void OnBtnPrivacyPolicyClick()
		{
		}

		// Token: 0x06007390 RID: 29584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007390")]
		[Address(RVA = "0x1E70364", Offset = "0x1E70364", VA = "0x7BBC670364")]
		public UIElitePassSubscriptionController()
		{
		}

		// Token: 0x04008BE8 RID: 35816
		[Token(Token = "0x4008BE8")]
		[FieldOffset(Offset = "0xB0")]
		private UIElitePassSubscriptionView m_View;

		// Token: 0x04008BE9 RID: 35817
		[Token(Token = "0x4008BE9")]
		[FieldOffset(Offset = "0xB8")]
		private UIModelElitePass m_Model;

		// Token: 0x020017A4 RID: 6052
		[Token(Token = "0x20017A4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F281C", Offset = "0x10F281C")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06007392 RID: 29586 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007392")]
			[Address(RVA = "0x1E703D0", Offset = "0x1E703D0", VA = "0x7BBC6703D0")]
			public <>c()
			{
			}

			// Token: 0x06007393 RID: 29587 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007393")]
			[Address(RVA = "0x1E703D8", Offset = "0x1E703D8", VA = "0x7BBC6703D8")]
			internal void <OnUIInit>b__3_0()
			{
			}

			// Token: 0x06007394 RID: 29588 RVA: 0x00020160 File Offset: 0x0001E360
			[Token(Token = "0x6007394")]
			[Address(RVA = "0x1E70450", Offset = "0x1E70450", VA = "0x7BBC670450")]
			internal bool <UpdateCDNImage>b__5_0(AdvertDesc x)
			{
				return default(bool);
			}

			// Token: 0x04008BEA RID: 35818
			[Token(Token = "0x4008BEA")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIElitePassSubscriptionController.<>c <>9;

			// Token: 0x04008BEB RID: 35819
			[Token(Token = "0x4008BEB")]
			[FieldOffset(Offset = "0x8")]
			public static OnFinished <>9__3_0;

			// Token: 0x04008BEC RID: 35820
			[Token(Token = "0x4008BEC")]
			[FieldOffset(Offset = "0x10")]
			public static Predicate<AdvertDesc> <>9__5_0;
		}
	}
}
