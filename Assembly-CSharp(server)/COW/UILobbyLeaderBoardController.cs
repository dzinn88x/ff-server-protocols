using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001A05 RID: 6661
	[Token(Token = "0x2001A05")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F76C4", Offset = "0x10F76C4")]
	internal class UILobbyLeaderBoardController : UIBaseController, IUIModelDataChangeObserver
	{
		// Token: 0x06008A96 RID: 35478 RVA: 0x000252C0 File Offset: 0x000234C0
		[Token(Token = "0x6008A96")]
		[Address(RVA = "0x143FB94", Offset = "0x143FB94", VA = "0x7BBBC3FB94")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008A97 RID: 35479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008A97")]
		[Address(RVA = "0x143FBE4", Offset = "0x143FBE4", VA = "0x7BBBC3FBE4", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008A98 RID: 35480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008A98")]
		[Address(RVA = "0x143FE48", Offset = "0x143FE48", VA = "0x7BBBC3FE48", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06008A99 RID: 35481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008A99")]
		[Address(RVA = "0x143FEFC", Offset = "0x143FEFC", VA = "0x7BBBC3FEFC")]
		private void SetUIData()
		{
		}

		// Token: 0x06008A9A RID: 35482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008A9A")]
		[Address(RVA = "0x1440218", Offset = "0x1440218", VA = "0x7BBBC40218")]
		private void OnInitContent(GameObject go, int wrapIndex, int realIndex)
		{
		}

		// Token: 0x06008A9B RID: 35483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008A9B")]
		[Address(RVA = "0x14402C4", Offset = "0x14402C4", VA = "0x7BBBC402C4")]
		private void OnMoreClick()
		{
		}

		// Token: 0x06008A9C RID: 35484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008A9C")]
		[Address(RVA = "0x14402C8", Offset = "0x14402C8", VA = "0x7BBBC402C8", Slot = "28")]
		private void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06008A9D RID: 35485 RVA: 0x000252D8 File Offset: 0x000234D8
		[Token(Token = "0x6008A9D")]
		[Address(RVA = "0x1440454", Offset = "0x1440454", VA = "0x7BBBC40454", Slot = "29")]
		private uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06008A9E RID: 35486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008A9E")]
		[Address(RVA = "0x1440498", Offset = "0x1440498", VA = "0x7BBBC40498")]
		public UILobbyLeaderBoardController()
		{
		}

		// Token: 0x04009804 RID: 38916
		[Token(Token = "0x4009804")]
		[FieldOffset(Offset = "0x58")]
		private UILobbyLeaderBoardView m_View;

		// Token: 0x04009805 RID: 38917
		[Token(Token = "0x4009805")]
		[FieldOffset(Offset = "0x60")]
		private List<LeaderBoardInfo> m_TopRankList;
	}
}
