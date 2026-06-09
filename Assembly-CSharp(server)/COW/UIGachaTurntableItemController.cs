using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200182D RID: 6189
	[Token(Token = "0x200182D")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F380C", Offset = "0x10F380C")]
	public class UIGachaTurntableItemController : UIBaseController
	{
		// Token: 0x1700096C RID: 2412
		// (get) Token: 0x060078FE RID: 30974 RVA: 0x000214E0 File Offset: 0x0001F6E0
		[Token(Token = "0x1700096C")]
		public int Index
		{
			[Token(Token = "0x60078FE")]
			[Address(RVA = "0x1FAD68C", Offset = "0x1FAD68C", VA = "0x7BBC7AD68C")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700096D RID: 2413
		// (get) Token: 0x060078FF RID: 30975 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700096D")]
		public BaseItemInfo Info
		{
			[Token(Token = "0x60078FF")]
			[Address(RVA = "0x1FAD694", Offset = "0x1FAD694", VA = "0x7BBC7AD694")]
			get
			{
				return null;
			}
		}

		// Token: 0x06007900 RID: 30976 RVA: 0x000214F8 File Offset: 0x0001F6F8
		[Token(Token = "0x6007900")]
		[Address(RVA = "0x1FAF4AC", Offset = "0x1FAF4AC", VA = "0x7BBC7AF4AC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007901 RID: 30977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007901")]
		[Address(RVA = "0x1FAF4FC", Offset = "0x1FAF4FC", VA = "0x7BBC7AF4FC", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007902 RID: 30978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007902")]
		[Address(RVA = "0x1FAF628", Offset = "0x1FAF628", VA = "0x7BBC7AF628")]
		private void OnBtnTipClick()
		{
		}

		// Token: 0x06007903 RID: 30979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007903")]
		[Address(RVA = "0x1FABA64", Offset = "0x1FABA64", VA = "0x7BBC7ABA64")]
		public void SetViewInfo(uint gachaID, int idx, BaseItemInfo info, bool isShowDropUp = false)
		{
		}

		// Token: 0x06007904 RID: 30980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007904")]
		[Address(RVA = "0x1FABF28", Offset = "0x1FABF28", VA = "0x7BBC7ABF28")]
		public void ShowView(UIGachaTurntableItemController.ViewStage stage, float alpha = 1f)
		{
		}

		// Token: 0x06007905 RID: 30981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007905")]
		[Address(RVA = "0x1FAF72C", Offset = "0x1FAF72C", VA = "0x7BBC7AF72C")]
		private void PlaySelectedAudio()
		{
		}

		// Token: 0x06007906 RID: 30982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007906")]
		[Address(RVA = "0x1FAF7C8", Offset = "0x1FAF7C8", VA = "0x7BBC7AF7C8")]
		private void PlayGetRewardAudio()
		{
		}

		// Token: 0x06007907 RID: 30983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007907")]
		[Address(RVA = "0x1FAF864", Offset = "0x1FAF864", VA = "0x7BBC7AF864", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x06007908 RID: 30984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007908")]
		[Address(RVA = "0x1FAF86C", Offset = "0x1FAF86C", VA = "0x7BBC7AF86C", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06007909 RID: 30985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007909")]
		[Address(RVA = "0x1FAAAB4", Offset = "0x1FAAAB4", VA = "0x7BBC7AAAB4")]
		public void PlayAnim()
		{
		}

		// Token: 0x0600790A RID: 30986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600790A")]
		[Address(RVA = "0x1FAAD0C", Offset = "0x1FAAD0C", VA = "0x7BBC7AAD0C")]
		public void ResetAnim()
		{
		}

		// Token: 0x0600790B RID: 30987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600790B")]
		[Address(RVA = "0x1FAF874", Offset = "0x1FAF874", VA = "0x7BBC7AF874")]
		public UIGachaTurntableItemController()
		{
		}

		// Token: 0x04008E89 RID: 36489
		[Token(Token = "0x4008E89")]
		[FieldOffset(Offset = "0x58")]
		private uint m_GachaID;

		// Token: 0x04008E8A RID: 36490
		[Token(Token = "0x4008E8A")]
		[FieldOffset(Offset = "0x60")]
		private UIGachaTurntableItemView m_View;

		// Token: 0x04008E8B RID: 36491
		[Token(Token = "0x4008E8B")]
		[FieldOffset(Offset = "0x68")]
		private int m_Idx;

		// Token: 0x04008E8C RID: 36492
		[Token(Token = "0x4008E8C")]
		[FieldOffset(Offset = "0x70")]
		private BaseItemInfo m_Info;

		// Token: 0x0200182E RID: 6190
		[Token(Token = "0x200182E")]
		public enum ViewStage
		{
			// Token: 0x04008E8E RID: 36494
			[Token(Token = "0x4008E8E")]
			NORMAL,
			// Token: 0x04008E8F RID: 36495
			[Token(Token = "0x4008E8F")]
			TRANSLUCENT,
			// Token: 0x04008E90 RID: 36496
			[Token(Token = "0x4008E90")]
			HIGHLIGHT,
			// Token: 0x04008E91 RID: 36497
			[Token(Token = "0x4008E91")]
			SELECTED,
			// Token: 0x04008E92 RID: 36498
			[Token(Token = "0x4008E92")]
			GET_REWARD
		}
	}
}
