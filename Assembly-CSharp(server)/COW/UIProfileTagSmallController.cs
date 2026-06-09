using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001B32 RID: 6962
	[Token(Token = "0x2001B32")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F96EC", Offset = "0x10F96EC")]
	public class UIProfileTagSmallController : UIBaseController
	{
		// Token: 0x0600956D RID: 38253 RVA: 0x00027870 File Offset: 0x00025A70
		[Token(Token = "0x600956D")]
		[Address(RVA = "0x1FF09FC", Offset = "0x1FF09FC", VA = "0x7BBC7F09FC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600956E RID: 38254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600956E")]
		[Address(RVA = "0x1FF0A4C", Offset = "0x1FF0A4C", VA = "0x7BBC7F0A4C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600956F RID: 38255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600956F")]
		[Address(RVA = "0x1FF0CCC", Offset = "0x1FF0CCC", VA = "0x7BBC7F0CCC")]
		public void DisableClick()
		{
		}

		// Token: 0x06009570 RID: 38256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009570")]
		[Address(RVA = "0x1FEEDB8", Offset = "0x1FEEDB8", VA = "0x7BBC7EEDB8")]
		public void SetViewData(PlayerTagDataBase data, ProfileTagType type, bool refreshbg = true)
		{
		}

		// Token: 0x06009571 RID: 38257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009571")]
		[Address(RVA = "0x1FF0CD8", Offset = "0x1FF0CD8", VA = "0x7BBC7F0CD8")]
		private void RefreshSocialView(PlayerTagDataBase data, bool refreshbg = true)
		{
		}

		// Token: 0x06009572 RID: 38258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009572")]
		[Address(RVA = "0x1FF0E90", Offset = "0x1FF0E90", VA = "0x7BBC7F0E90")]
		private void RefreshBattleView(PlayerTagDataBase data, bool refreshbg = true)
		{
		}

		// Token: 0x06009573 RID: 38259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009573")]
		[Address(RVA = "0x1FF11D4", Offset = "0x1FF11D4", VA = "0x7BBC7F11D4")]
		public void SetSelectedState(bool selected)
		{
		}

		// Token: 0x06009574 RID: 38260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009574")]
		[Address(RVA = "0x1FF121C", Offset = "0x1FF121C", VA = "0x7BBC7F121C")]
		public void SetEquipedState(bool equiped)
		{
		}

		// Token: 0x06009575 RID: 38261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009575")]
		[Address(RVA = "0x1FF127C", Offset = "0x1FF127C", VA = "0x7BBC7F127C")]
		private void OnSmallTagClick()
		{
		}

		// Token: 0x06009576 RID: 38262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009576")]
		[Address(RVA = "0x1FF1404", Offset = "0x1FF1404", VA = "0x7BBC7F1404")]
		public void DisableBtn()
		{
		}

		// Token: 0x06009577 RID: 38263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009577")]
		[Address(RVA = "0x1FF144C", Offset = "0x1FF144C", VA = "0x7BBC7F144C")]
		public void EnableHover()
		{
		}

		// Token: 0x06009578 RID: 38264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009578")]
		[Address(RVA = "0x1FEA680", Offset = "0x1FEA680", VA = "0x7BBC7EA680")]
		public void SetPreviewState(int index)
		{
		}

		// Token: 0x06009579 RID: 38265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009579")]
		[Address(RVA = "0x1FF14A8", Offset = "0x1FF14A8", VA = "0x7BBC7F14A8")]
		public UIProfileTagSmallController()
		{
		}

		// Token: 0x0600957A RID: 38266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600957A")]
		[Address(RVA = "0x1FF14B0", Offset = "0x1FF14B0", VA = "0x7BBC7F14B0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1144C80", Offset = "0x1144C80")]
		private void <OnUIInit>b__7_0(bool flag)
		{
		}

		// Token: 0x04009EA4 RID: 40612
		[Token(Token = "0x4009EA4")]
		[FieldOffset(Offset = "0x58")]
		private UIProfileSmallTagView m_View;

		// Token: 0x04009EA5 RID: 40613
		[Token(Token = "0x4009EA5")]
		[FieldOffset(Offset = "0x60")]
		private PlayerTagDataBase m_Data;

		// Token: 0x04009EA6 RID: 40614
		[Token(Token = "0x4009EA6")]
		[FieldOffset(Offset = "0x68")]
		private ProfileTagType m_Type;

		// Token: 0x04009EA7 RID: 40615
		[Token(Token = "0x4009EA7")]
		[FieldOffset(Offset = "0x6C")]
		private int level;

		// Token: 0x04009EA8 RID: 40616
		[Token(Token = "0x4009EA8")]
		[FieldOffset(Offset = "0x70")]
		private int m_PreviewNum;

		// Token: 0x04009EA9 RID: 40617
		[Token(Token = "0x4009EA9")]
		[FieldOffset(Offset = "0x74")]
		private bool m_DisableClick;
	}
}
