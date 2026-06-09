using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001786 RID: 6022
	[Token(Token = "0x2001786")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F23AC", Offset = "0x10F23AC")]
	public class UIDebugLoginController : UIPopupWindowController, IUIModelDataChangeObserver
	{
		// Token: 0x06007268 RID: 29288 RVA: 0x0001FD70 File Offset: 0x0001DF70
		[Token(Token = "0x6007268")]
		[Address(RVA = "0x1BBBD50", Offset = "0x1BBBD50", VA = "0x7BBC3BBD50")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007269 RID: 29289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007269")]
		[Address(RVA = "0x1BBBDA0", Offset = "0x1BBBDA0", VA = "0x7BBC3BBDA0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600726A RID: 29290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600726A")]
		[Address(RVA = "0x1BBBFF4", Offset = "0x1BBBFF4", VA = "0x7BBC3BBFF4")]
		private void RefreshViewData()
		{
		}

		// Token: 0x0600726B RID: 29291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600726B")]
		[Address(RVA = "0x1BBC368", Offset = "0x1BBC368", VA = "0x7BBC3BC368", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x0600726C RID: 29292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600726C")]
		[Address(RVA = "0x1BBC120", Offset = "0x1BBC120", VA = "0x7BBC3BC120")]
		private void OnInputChange()
		{
		}

		// Token: 0x0600726D RID: 29293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600726D")]
		[Address(RVA = "0x1BBC41C", Offset = "0x1BBC41C", VA = "0x7BBC3BC41C")]
		private void OnConfirmClick()
		{
		}

		// Token: 0x0600726E RID: 29294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600726E")]
		[Address(RVA = "0x1BBC420", Offset = "0x1BBC420", VA = "0x7BBC3BC420", Slot = "40")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x0600726F RID: 29295 RVA: 0x0001FD88 File Offset: 0x0001DF88
		[Token(Token = "0x600726F")]
		[Address(RVA = "0x1BBC4A0", Offset = "0x1BBC4A0", VA = "0x7BBC3BC4A0", Slot = "41")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06007270 RID: 29296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007270")]
		[Address(RVA = "0x1BBC4E4", Offset = "0x1BBC4E4", VA = "0x7BBC3BC4E4")]
		public UIDebugLoginController()
		{
		}

		// Token: 0x04008B67 RID: 35687
		[Token(Token = "0x4008B67")]
		[FieldOffset(Offset = "0x98")]
		private UIAccountIDNickNameLoginWindowView m_View;

		// Token: 0x04008B68 RID: 35688
		[Token(Token = "0x4008B68")]
		private const uint BTN_DEFUALT_COLOR = 1608186111U;

		// Token: 0x04008B69 RID: 35689
		[Token(Token = "0x4008B69")]
		private const uint BTN_GREY_COLOR = 2593823487U;

		// Token: 0x04008B6A RID: 35690
		[Token(Token = "0x4008B6A")]
		private const uint OUTLINE_BLUE = 192872447U;

		// Token: 0x04008B6B RID: 35691
		[Token(Token = "0x4008B6B")]
		private const uint LABEL_GEM_COLOR = 188765951U;

		// Token: 0x04008B6C RID: 35692
		[Token(Token = "0x4008B6C")]
		[FieldOffset(Offset = "0xA0")]
		private LoginRes m_UserData;

		// Token: 0x04008B6D RID: 35693
		[Token(Token = "0x4008B6D")]
		[FieldOffset(Offset = "0xA8")]
		private RenameCostData m_CostData;

		// Token: 0x04008B6E RID: 35694
		[Token(Token = "0x4008B6E")]
		[FieldOffset(Offset = "0xB0")]
		private bool m_HasRequestedLogin;
	}
}
