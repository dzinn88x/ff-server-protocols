using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001662 RID: 5730
	[Token(Token = "0x2001662")]
	internal class UIHUDTeamBattleScoreBoardController<T> : UIBaseController where T : UIHUDTeamBattleScoreBoardItemController
	{
		// Token: 0x06006784 RID: 26500 RVA: 0x0001D790 File Offset: 0x0001B990
		[Token(Token = "0x6006784")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x1700090F RID: 2319
		// (get) Token: 0x06006785 RID: 26501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700090F")]
		protected List<EMatchResultPlayerInfoType> InfoTypeList
		{
			[Token(Token = "0x6006785")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000910 RID: 2320
		// (get) Token: 0x06006786 RID: 26502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000910")]
		protected Dictionary<{QAb\u0082~u, T> ItemCtrlList
		{
			[Token(Token = "0x6006786")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006787 RID: 26503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006787")]
		protected virtual void SetInfoType()
		{
		}

		// Token: 0x06006788 RID: 26504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006788")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006789 RID: 26505 RVA: 0x0001D7A8 File Offset: 0x0001B9A8
		[Token(Token = "0x6006789")]
		protected virtual ResourceID GetTitileResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600678A RID: 26506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600678A")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x0600678B RID: 26507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600678B")]
		public virtual void RegisterUIEvent()
		{
		}

		// Token: 0x0600678C RID: 26508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600678C")]
		public virtual void UnRegisterUIEvent()
		{
		}

		// Token: 0x0600678D RID: 26509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600678D")]
		private void ClosePage()
		{
		}

		// Token: 0x0600678E RID: 26510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600678E")]
		public virtual T InitOneItem(Transform parent)
		{
			return null;
		}

		// Token: 0x0600678F RID: 26511 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600678F")]
		private T CreateItem<T>(Transform parent) where T : UIHUDTeamBattleScoreBoardItemController
		{
			return null;
		}

		// Token: 0x06006790 RID: 26512 RVA: 0x0001D7C0 File Offset: 0x0001B9C0
		[Token(Token = "0x6006790")]
		public virtual int ItemCustomSort(Transform transform1, Transform transform2)
		{
			return 0;
		}

		// Token: 0x06006791 RID: 26513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006791")]
		public void OnAddPlayer(params object[] param)
		{
		}

		// Token: 0x06006792 RID: 26514 RVA: 0x0001D7D8 File Offset: 0x0001B9D8
		[Token(Token = "0x6006792")]
		protected virtual bool IsTeamOnLeft({QAb\u0082~u pId)
		{
			return default(bool);
		}

		// Token: 0x06006793 RID: 26515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006793")]
		public void OnPlayerQuit(params object[] param)
		{
		}

		// Token: 0x06006794 RID: 26516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006794")]
		public virtual void RefreshGrid()
		{
		}

		// Token: 0x06006795 RID: 26517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006795")]
		public void UpdateLeftScore(int leftScore)
		{
		}

		// Token: 0x06006796 RID: 26518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006796")]
		public void UpdateRightScore(int rightScore)
		{
		}

		// Token: 0x06006797 RID: 26519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006797")]
		public void UpdateLeftCustomIcon(ResourceID spriteName, UIUtils.SpriteScaleType scaleType = UIUtils.SpriteScaleType.Fit, bool makePixelPerfect = true)
		{
		}

		// Token: 0x06006798 RID: 26520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006798")]
		public void UpdateRightCustomIcon(ResourceID spriteName, UIUtils.SpriteScaleType scaleType = UIUtils.SpriteScaleType.Fit, bool makePixelPerfect = true)
		{
		}

		// Token: 0x06006799 RID: 26521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006799")]
		public virtual void UpdateAllTitle()
		{
		}

		// Token: 0x0600679A RID: 26522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600679A")]
		protected void UpdateInfoTitle(UILabel infoTxt, int index)
		{
		}

		// Token: 0x0600679B RID: 26523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600679B")]
		public void UpdateTeamInfo(Player player, bool isUpdateLeft)
		{
		}

		// Token: 0x0600679C RID: 26524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600679C")]
		protected virtual void OnKillCountChanged(params object[] param)
		{
		}

		// Token: 0x0600679D RID: 26525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600679D")]
		protected virtual void OnDeadCountChanged(params object[] param)
		{
		}

		// Token: 0x0600679E RID: 26526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600679E")]
		protected void OnAssistCountChanged(params object[] param)
		{
		}

		// Token: 0x0600679F RID: 26527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600679F")]
		protected virtual void OnTotalDamageChanged(params object[] param)
		{
		}

		// Token: 0x060067A0 RID: 26528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60067A0")]
		protected void RefreshItemDataByPlayerID({QAb\u0082~u playerId)
		{
		}

		// Token: 0x060067A1 RID: 26529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60067A1")]
		protected void RefreshItemData({QAb\u0082~u playerId, int index, string msg)
		{
		}

		// Token: 0x060067A2 RID: 26530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60067A2")]
		public UIHUDTeamBattleScoreBoardController()
		{
		}

		// Token: 0x040084D7 RID: 34007
		[Token(Token = "0x40084D7")]
		[FieldOffset(Offset = "0x0")]
		protected TeamScoreBoardView m_View;

		// Token: 0x040084D8 RID: 34008
		[Token(Token = "0x40084D8")]
		[FieldOffset(Offset = "0x0")]
		private List<EMatchResultPlayerInfoType> m_InfoTypeList;

		// Token: 0x040084D9 RID: 34009
		[Token(Token = "0x40084D9")]
		[FieldOffset(Offset = "0x0")]
		protected Dictionary<{QAb\u0082~u, T> m_ItemCtrlDic;

		// Token: 0x040084DA RID: 34010
		[Token(Token = "0x40084DA")]
		[FieldOffset(Offset = "0x0")]
		private List<T> m_LeftItemList;

		// Token: 0x040084DB RID: 34011
		[Token(Token = "0x40084DB")]
		[FieldOffset(Offset = "0x0")]
		private List<T> m_RightItemList;

		// Token: 0x040084DC RID: 34012
		[Token(Token = "0x40084DC")]
		[FieldOffset(Offset = "0x0")]
		protected int m_LocalPlayerTeamId;
	}
}
