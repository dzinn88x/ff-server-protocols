using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200186E RID: 6254
	[Token(Token = "0x200186E")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F40CC", Offset = "0x10F40CC")]
	public class UIHUDArmsLevelUPTipController : UIBaseController, IUIModelDataChangeObserver
	{
		// Token: 0x06007B61 RID: 31585 RVA: 0x00021EE8 File Offset: 0x000200E8
		[Token(Token = "0x6007B61")]
		[Address(RVA = "0x16B0248", Offset = "0x16B0248", VA = "0x7BBBEB0248")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007B62 RID: 31586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B62")]
		[Address(RVA = "0x16B0298", Offset = "0x16B0298", VA = "0x7BBBEB0298", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007B63 RID: 31587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B63")]
		[Address(RVA = "0x16B03E8", Offset = "0x16B03E8", VA = "0x7BBBEB03E8", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06007B64 RID: 31588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B64")]
		[Address(RVA = "0x16B0520", Offset = "0x16B0520", VA = "0x7BBBEB0520", Slot = "28")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06007B65 RID: 31589 RVA: 0x00021F00 File Offset: 0x00020100
		[Token(Token = "0x6007B65")]
		[Address(RVA = "0x16B06C8", Offset = "0x16B06C8", VA = "0x7BBBEB06C8", Slot = "29")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06007B66 RID: 31590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B66")]
		[Address(RVA = "0x16B070C", Offset = "0x16B070C", VA = "0x7BBBEB070C")]
		public void ArmsRaceShowTip(params object[] param)
		{
		}

		// Token: 0x06007B67 RID: 31591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B67")]
		[Address(RVA = "0x16B0594", Offset = "0x16B0594", VA = "0x7BBBEB0594")]
		public void ShowTip()
		{
		}

		// Token: 0x06007B68 RID: 31592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B68")]
		[Address(RVA = "0x16B0920", Offset = "0x16B0920", VA = "0x7BBBEB0920")]
		public void HideTip()
		{
		}

		// Token: 0x06007B69 RID: 31593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B69")]
		[Address(RVA = "0x16B0930", Offset = "0x16B0930", VA = "0x7BBBEB0930")]
		public UIHUDArmsLevelUPTipController()
		{
		}

		// Token: 0x04008FE2 RID: 36834
		[Token(Token = "0x4008FE2")]
		[FieldOffset(Offset = "0x58")]
		private UIHUDArmsLevelUPTipView m_View;

		// Token: 0x04008FE3 RID: 36835
		[Token(Token = "0x4008FE3")]
		[FieldOffset(Offset = "0x60")]
		private int m_DelayHandle;
	}
}
