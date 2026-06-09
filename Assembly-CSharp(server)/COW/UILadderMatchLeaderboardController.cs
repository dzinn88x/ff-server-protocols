using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using message;
using UnityEngine;

namespace COW
{
	// Token: 0x0200152C RID: 5420
	[Token(Token = "0x200152C")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EE2DC", Offset = "0x10EE2DC")]
	internal class UILadderMatchLeaderboardController : UIBaseController, IUIModelDataChangeObserver, IEasyList
	{
		// Token: 0x170008AD RID: 2221
		// (get) Token: 0x06005D50 RID: 23888 RVA: 0x0001B198 File Offset: 0x00019398
		[Token(Token = "0x170008AD")]
		public f LadderMatchType
		{
			[Token(Token = "0x6005D50")]
			[Address(RVA = "0x1E865A0", Offset = "0x1E865A0", VA = "0x7BBC6865A0")]
			get
			{
				return f.EMATCHMODE_NONE;
			}
		}

		// Token: 0x06005D51 RID: 23889 RVA: 0x0001B1B0 File Offset: 0x000193B0
		[Token(Token = "0x6005D51")]
		[Address(RVA = "0x1E865A8", Offset = "0x1E865A8", VA = "0x7BBC6865A8")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005D52 RID: 23890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D52")]
		[Address(RVA = "0x1E865F8", Offset = "0x1E865F8", VA = "0x7BBC6865F8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005D53 RID: 23891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D53")]
		[Address(RVA = "0x1E86998", Offset = "0x1E86998", VA = "0x7BBC686998")]
		public void SetViewData(f ladderMatchType)
		{
		}

		// Token: 0x06005D54 RID: 23892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D54")]
		[Address(RVA = "0x1E86BEC", Offset = "0x1E86BEC", VA = "0x7BBC686BEC", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06005D55 RID: 23893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D55")]
		[Address(RVA = "0x1E86C4C", Offset = "0x1E86C4C", VA = "0x7BBC686C4C")]
		private void OnFriendTabClick()
		{
		}

		// Token: 0x06005D56 RID: 23894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D56")]
		[Address(RVA = "0x1E875D8", Offset = "0x1E875D8", VA = "0x7BBC6875D8")]
		private void OnGlobalTabClick()
		{
		}

		// Token: 0x06005D57 RID: 23895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D57")]
		[Address(RVA = "0x1E876A8", Offset = "0x1E876A8", VA = "0x7BBC6876A8")]
		public void InitTweenBoard()
		{
		}

		// Token: 0x06005D58 RID: 23896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D58")]
		[Address(RVA = "0x1E877D4", Offset = "0x1E877D4", VA = "0x7BBC6877D4")]
		public void OnBtnHideClick()
		{
		}

		// Token: 0x06005D59 RID: 23897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D59")]
		[Address(RVA = "0x1E87924", Offset = "0x1E87924", VA = "0x7BBC687924")]
		public void OnBtnCloseClick()
		{
		}

		// Token: 0x06005D5A RID: 23898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D5A")]
		[Address(RVA = "0x1E87014", Offset = "0x1E87014", VA = "0x7BBC687014")]
		private void RefreshSelfRank(List<LeaderBoardInfo> _list)
		{
		}

		// Token: 0x06005D5B RID: 23899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D5B")]
		[Address(RVA = "0x1E87440", Offset = "0x1E87440", VA = "0x7BBC687440")]
		private void RefreshSelfCSRank(bool isFriend = false)
		{
		}

		// Token: 0x06005D5C RID: 23900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D5C")]
		[Address(RVA = "0x1E86D1C", Offset = "0x1E86D1C", VA = "0x7BBC686D1C")]
		private void RefreshItemList(List<LeaderBoardInfo> _list)
		{
		}

		// Token: 0x06005D5D RID: 23901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D5D")]
		[Address(RVA = "0x1E87DCC", Offset = "0x1E87DCC", VA = "0x7BBC687DCC", Slot = "28")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06005D5E RID: 23902 RVA: 0x0001B1C8 File Offset: 0x000193C8
		[Token(Token = "0x6005D5E")]
		[Address(RVA = "0x1E87EB0", Offset = "0x1E87EB0", VA = "0x7BBC687EB0", Slot = "29")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06005D5F RID: 23903 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D5F")]
		[Address(RVA = "0x1E87F34", Offset = "0x1E87F34", VA = "0x7BBC687F34", Slot = "30")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x06005D60 RID: 23904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D60")]
		[Address(RVA = "0x1E87FC8", Offset = "0x1E87FC8", VA = "0x7BBC687FC8", Slot = "31")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x06005D61 RID: 23905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D61")]
		[Address(RVA = "0x1E87FF8", Offset = "0x1E87FF8", VA = "0x7BBC687FF8")]
		public UILadderMatchLeaderboardController()
		{
		}

		// Token: 0x06005D62 RID: 23906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D62")]
		[Address(RVA = "0x1E8801C", Offset = "0x1E8801C", VA = "0x7BBC68801C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113F914", Offset = "0x113F914")]
		private void <InitTweenBoard>b__19_0()
		{
		}

		// Token: 0x04007F00 RID: 32512
		[Token(Token = "0x4007F00")]
		[FieldOffset(Offset = "0x58")]
		private LadderMatchLeaderboardView m_View;

		// Token: 0x04007F01 RID: 32513
		[Token(Token = "0x4007F01")]
		[FieldOffset(Offset = "0x60")]
		private UIModelLeaderBoard m_ModelBoard;

		// Token: 0x04007F02 RID: 32514
		[Token(Token = "0x4007F02")]
		[FieldOffset(Offset = "0x68")]
		private UIModelCSLadderMatch m_ModelLadder;

		// Token: 0x04007F03 RID: 32515
		[Token(Token = "0x4007F03")]
		[FieldOffset(Offset = "0x70")]
		private uint m_BRFriendBoardType;

		// Token: 0x04007F04 RID: 32516
		[Token(Token = "0x4007F04")]
		[FieldOffset(Offset = "0x74")]
		private uint m_BRRegionBoardType;

		// Token: 0x04007F05 RID: 32517
		[Token(Token = "0x4007F05")]
		[FieldOffset(Offset = "0x78")]
		private int m_SeasonID;

		// Token: 0x04007F06 RID: 32518
		[Token(Token = "0x4007F06")]
		[FieldOffset(Offset = "0x7C")]
		private bool NeedResetListPos;

		// Token: 0x04007F07 RID: 32519
		[Token(Token = "0x4007F07")]
		[FieldOffset(Offset = "0x7D")]
		private bool m_IsShrink;

		// Token: 0x04007F08 RID: 32520
		[Token(Token = "0x4007F08")]
		[FieldOffset(Offset = "0x80")]
		private f m_LadderMatchType;

		// Token: 0x04007F09 RID: 32521
		[Token(Token = "0x4007F09")]
		[FieldOffset(Offset = "0x84")]
		private bool m_IsRegion;

		// Token: 0x04007F0A RID: 32522
		[Token(Token = "0x4007F0A")]
		[FieldOffset(Offset = "0x88")]
		private UILadderMatchLeaderboardItemController m_selfLeaderItem;
	}
}
