using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001434 RID: 5172
	[Token(Token = "0x2001434")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EC9D8", Offset = "0x10EC9D8")]
	public class UIAvatarAwakenStoryReplayController : UIBaseController, IUIModelDataChangeObserver
	{
		// Token: 0x060055CD RID: 21965 RVA: 0x000198A8 File Offset: 0x00017AA8
		[Token(Token = "0x60055CD")]
		[Address(RVA = "0x1B20C38", Offset = "0x1B20C38", VA = "0x7BBC320C38")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060055CE RID: 21966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055CE")]
		[Address(RVA = "0x1B20C88", Offset = "0x1B20C88", VA = "0x7BBC320C88", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060055CF RID: 21967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055CF")]
		[Address(RVA = "0x1B1F154", Offset = "0x1B1F154", VA = "0x7BBC31F154")]
		public void SetAvatar(uint curAvatarID)
		{
		}

		// Token: 0x060055D0 RID: 21968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055D0")]
		[Address(RVA = "0x1B211C8", Offset = "0x1B211C8", VA = "0x7BBC3211C8", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060055D1 RID: 21969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055D1")]
		[Address(RVA = "0x1B21208", Offset = "0x1B21208", VA = "0x7BBC321208", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x060055D2 RID: 21970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055D2")]
		[Address(RVA = "0x1B20E84", Offset = "0x1B20E84", VA = "0x7BBC320E84")]
		public void InitStoryList()
		{
		}

		// Token: 0x060055D3 RID: 21971 RVA: 0x000198C0 File Offset: 0x00017AC0
		[Token(Token = "0x60055D3")]
		[Address(RVA = "0x1B21328", Offset = "0x1B21328", VA = "0x7BBC321328")]
		private int SortItem(AvatarAwakenComicData a, AvatarAwakenComicData b)
		{
			return 0;
		}

		// Token: 0x060055D4 RID: 21972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055D4")]
		[Address(RVA = "0x1B2136C", Offset = "0x1B2136C", VA = "0x7BBC32136C", Slot = "28")]
		private void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x060055D5 RID: 21973 RVA: 0x000198D8 File Offset: 0x00017AD8
		[Token(Token = "0x60055D5")]
		[Address(RVA = "0x1B213F8", Offset = "0x1B213F8", VA = "0x7BBC3213F8", Slot = "29")]
		private uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x060055D6 RID: 21974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055D6")]
		[Address(RVA = "0x1B2143C", Offset = "0x1B2143C", VA = "0x7BBC32143C")]
		public UIAvatarAwakenStoryReplayController()
		{
		}

		// Token: 0x04007A93 RID: 31379
		[Token(Token = "0x4007A93")]
		[FieldOffset(Offset = "0x58")]
		private UIAvatarAwakenStoryReplayView m_View;

		// Token: 0x04007A94 RID: 31380
		[Token(Token = "0x4007A94")]
		[FieldOffset(Offset = "0x60")]
		private UIModelAvatarProfile m_Model;

		// Token: 0x04007A95 RID: 31381
		[Token(Token = "0x4007A95")]
		[FieldOffset(Offset = "0x68")]
		private RewardWndCfg m_PendingRewardCfg;

		// Token: 0x04007A96 RID: 31382
		[Token(Token = "0x4007A96")]
		[FieldOffset(Offset = "0x70")]
		private List<UIPanel> m_ComicPosList;

		// Token: 0x04007A97 RID: 31383
		[Token(Token = "0x4007A97")]
		[FieldOffset(Offset = "0x78")]
		private AvatarProfile m_CurrentShowAvatar;
	}
}
