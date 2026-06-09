using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001B31 RID: 6961
	[Token(Token = "0x2001B31")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F96B4", Offset = "0x10F96B4")]
	public class UIProfileTagController : UIBaseController
	{
		// Token: 0x06009564 RID: 38244 RVA: 0x00027858 File Offset: 0x00025A58
		[Token(Token = "0x6009564")]
		[Address(RVA = "0x1FF00C4", Offset = "0x1FF00C4", VA = "0x7BBC7F00C4")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06009565 RID: 38245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009565")]
		[Address(RVA = "0x1FF0114", Offset = "0x1FF0114", VA = "0x7BBC7F0114", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06009566 RID: 38246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009566")]
		[Address(RVA = "0x1FEEAC0", Offset = "0x1FEEAC0", VA = "0x7BBC7EEAC0")]
		public void SetViewData(PlayerTagDataBase data, ProfileTagType type, bool refreshbg = true)
		{
		}

		// Token: 0x06009567 RID: 38247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009567")]
		[Address(RVA = "0x1FF02E8", Offset = "0x1FF02E8", VA = "0x7BBC7F02E8")]
		private void RefreshSocialView(PlayerTagDataBase data, bool refreshbg = true)
		{
		}

		// Token: 0x06009568 RID: 38248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009568")]
		[Address(RVA = "0x1FF04B4", Offset = "0x1FF04B4", VA = "0x7BBC7F04B4")]
		private void RefreshBattleView(PlayerTagDataBase data, bool refreshbg = true)
		{
		}

		// Token: 0x06009569 RID: 38249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009569")]
		[Address(RVA = "0x1FEEAE8", Offset = "0x1FEEAE8", VA = "0x7BBC7EEAE8")]
		public void SetSelectedState(bool selected)
		{
		}

		// Token: 0x0600956A RID: 38250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600956A")]
		[Address(RVA = "0x1FF0940", Offset = "0x1FF0940", VA = "0x7BBC7F0940")]
		public void SetEquipedState(bool equiped)
		{
		}

		// Token: 0x0600956B RID: 38251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600956B")]
		[Address(RVA = "0x1FE7988", Offset = "0x1FE7988", VA = "0x7BBC7E7988")]
		public void OnTagClick()
		{
		}

		// Token: 0x0600956C RID: 38252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600956C")]
		[Address(RVA = "0x1FF09A0", Offset = "0x1FF09A0", VA = "0x7BBC7F09A0")]
		public UIProfileTagController()
		{
		}

		// Token: 0x04009E9E RID: 40606
		[Token(Token = "0x4009E9E")]
		[FieldOffset(Offset = "0x58")]
		private UIProfileTagView m_View;

		// Token: 0x04009E9F RID: 40607
		[Token(Token = "0x4009E9F")]
		[FieldOffset(Offset = "0x60")]
		private PlayerTagDataBase m_Data;

		// Token: 0x04009EA0 RID: 40608
		[Token(Token = "0x4009EA0")]
		[FieldOffset(Offset = "0x68")]
		private ProfileTagType m_Type;

		// Token: 0x04009EA1 RID: 40609
		[Token(Token = "0x4009EA1")]
		[FieldOffset(Offset = "0x6C")]
		private int level;

		// Token: 0x04009EA2 RID: 40610
		[Token(Token = "0x4009EA2")]
		[FieldOffset(Offset = "0x70")]
		private int m_PreviewNum;

		// Token: 0x04009EA3 RID: 40611
		[Token(Token = "0x4009EA3")]
		[FieldOffset(Offset = "0x74")]
		private Color colorlock;
	}
}
