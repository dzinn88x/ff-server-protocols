using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001AA7 RID: 6823
	[Token(Token = "0x2001AA7")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F8854", Offset = "0x10F8854")]
	public class UINewPlayerUpGradeItemController : UIBaseController
	{
		// Token: 0x06008FE3 RID: 36835 RVA: 0x00026568 File Offset: 0x00024768
		[Token(Token = "0x6008FE3")]
		[Address(RVA = "0x1AFDA30", Offset = "0x1AFDA30", VA = "0x7BBC2FDA30")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008FE4 RID: 36836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008FE4")]
		[Address(RVA = "0x1AFDA80", Offset = "0x1AFDA80", VA = "0x7BBC2FDA80", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008FE5 RID: 36837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008FE5")]
		[Address(RVA = "0x1AFDC30", Offset = "0x1AFDC30", VA = "0x7BBC2FDC30")]
		private void SetCDNTexture(string url)
		{
		}

		// Token: 0x06008FE6 RID: 36838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008FE6")]
		[Address(RVA = "0x1AFDC90", Offset = "0x1AFDC90", VA = "0x7BBC2FDC90", Slot = "28")]
		public virtual void SetRewardData(ClientNewPlayerLevelUpTaskInfo taskinfo, int listIndex)
		{
		}

		// Token: 0x06008FE7 RID: 36839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008FE7")]
		[Address(RVA = "0x1AFE278", Offset = "0x1AFE278", VA = "0x7BBC2FE278")]
		private void SetLockState()
		{
		}

		// Token: 0x06008FE8 RID: 36840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008FE8")]
		[Address(RVA = "0x1AFE548", Offset = "0x1AFE548", VA = "0x7BBC2FE548")]
		private void SetNeedCliamedState()
		{
		}

		// Token: 0x06008FE9 RID: 36841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008FE9")]
		[Address(RVA = "0x1AFE638", Offset = "0x1AFE638", VA = "0x7BBC2FE638")]
		private void SetClaimedState()
		{
		}

		// Token: 0x06008FEA RID: 36842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008FEA")]
		[Address(RVA = "0x1AFE7A0", Offset = "0x1AFE7A0", VA = "0x7BBC2FE7A0", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06008FEB RID: 36843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008FEB")]
		[Address(RVA = "0x1AFE7A8", Offset = "0x1AFE7A8", VA = "0x7BBC2FE7A8")]
		protected void OnCliamButtonCick()
		{
		}

		// Token: 0x06008FEC RID: 36844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008FEC")]
		[Address(RVA = "0x1AFE728", Offset = "0x1AFE728", VA = "0x7BBC2FE728")]
		private void SetAlpha(UISprite sprite, float a)
		{
		}

		// Token: 0x06008FED RID: 36845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008FED")]
		[Address(RVA = "0x1AFE7F0", Offset = "0x1AFE7F0", VA = "0x7BBC2FE7F0")]
		protected void OnPreviewBtnClick()
		{
		}

		// Token: 0x06008FEE RID: 36846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008FEE")]
		[Address(RVA = "0x1AFE05C", Offset = "0x1AFE05C", VA = "0x7BBC2FE05C")]
		private void SetBgColor(char type)
		{
		}

		// Token: 0x06008FEF RID: 36847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008FEF")]
		[Address(RVA = "0x1AFE8AC", Offset = "0x1AFE8AC", VA = "0x7BBC2FE8AC")]
		public UINewPlayerUpGradeItemController()
		{
		}

		// Token: 0x04009BDE RID: 39902
		[Token(Token = "0x4009BDE")]
		[FieldOffset(Offset = "0x58")]
		protected int m_index;

		// Token: 0x04009BDF RID: 39903
		[Token(Token = "0x4009BDF")]
		[FieldOffset(Offset = "0x60")]
		protected UIModelNewPlayerUpGrade m_model;

		// Token: 0x04009BE0 RID: 39904
		[Token(Token = "0x4009BE0")]
		[FieldOffset(Offset = "0x68")]
		protected UIModelAvatarProfile m_UIModelAvatarProfile;

		// Token: 0x04009BE1 RID: 39905
		[Token(Token = "0x4009BE1")]
		[FieldOffset(Offset = "0x70")]
		protected ClientNewPlayerLevelUpTaskInfo taskinfo;

		// Token: 0x04009BE2 RID: 39906
		[Token(Token = "0x4009BE2")]
		[FieldOffset(Offset = "0x78")]
		protected NewPlayerUpGradeCliamState m_NewPlayerUpGradeCliamState;

		// Token: 0x04009BE3 RID: 39907
		[Token(Token = "0x4009BE3")]
		[FieldOffset(Offset = "0x80")]
		protected UINewPlayerUpGradeItemView m_View;
	}
}
