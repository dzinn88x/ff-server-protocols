using System;
using GCommon;
using Il2CppDummyDll;
using message;
using UnityEngine;

namespace COW
{
	// Token: 0x02001B77 RID: 7031
	[Token(Token = "0x2001B77")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FA21C", Offset = "0x10FA21C")]
	internal class UISeasonStatsDetailController : UINavigationController
	{
		// Token: 0x06009770 RID: 38768 RVA: 0x00027F48 File Offset: 0x00026148
		[Token(Token = "0x6009770")]
		[Address(RVA = "0x162A878", Offset = "0x162A878", VA = "0x7BBBE2A878")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06009771 RID: 38769 RVA: 0x00027F60 File Offset: 0x00026160
		[Token(Token = "0x6009771")]
		[Address(RVA = "0x162A8C8", Offset = "0x162A8C8", VA = "0x7BBBE2A8C8", Slot = "33")]
		public override EFrontendUIType GetBackgroundImageType()
		{
			return EFrontendUIType.Lobby;
		}

		// Token: 0x06009772 RID: 38770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009772")]
		[Address(RVA = "0x162A8D0", Offset = "0x162A8D0", VA = "0x7BBBE2A8D0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06009773 RID: 38771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009773")]
		[Address(RVA = "0x162B088", Offset = "0x162B088", VA = "0x7BBBE2B088", Slot = "28")]
		public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
		{
		}

		// Token: 0x06009774 RID: 38772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009774")]
		[Address(RVA = "0x162B2A4", Offset = "0x162B2A4", VA = "0x7BBBE2B2A4")]
		private void OnShareBtnClick()
		{
		}

		// Token: 0x06009775 RID: 38773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009775")]
		[Address(RVA = "0x162B140", Offset = "0x162B140", VA = "0x7BBBE2B140")]
		public void SetViewData(f ladderMatchType)
		{
		}

		// Token: 0x06009776 RID: 38774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009776")]
		[Address(RVA = "0x162C15C", Offset = "0x162C15C", VA = "0x7BBBE2C15C")]
		private void RefreshCSData()
		{
		}

		// Token: 0x06009777 RID: 38775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009777")]
		[Address(RVA = "0x162B478", Offset = "0x162B478", VA = "0x7BBBE2B478")]
		private void RefreshBRData()
		{
		}

		// Token: 0x06009778 RID: 38776 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009778")]
		[Address(RVA = "0x162D10C", Offset = "0x162D10C", VA = "0x7BBBE2D10C")]
		private string SecFormat(uint _sec)
		{
			return null;
		}

		// Token: 0x06009779 RID: 38777 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009779")]
		[Address(RVA = "0x162D1A8", Offset = "0x162D1A8", VA = "0x7BBBE2D1A8")]
		private string uniFormat(uint n)
		{
			return null;
		}

		// Token: 0x0600977A RID: 38778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600977A")]
		[Address(RVA = "0x162D23C", Offset = "0x162D23C", VA = "0x7BBBE2D23C", Slot = "23")]
		public override void BeforeScreenshot()
		{
		}

		// Token: 0x0600977B RID: 38779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600977B")]
		[Address(RVA = "0x162D2A4", Offset = "0x162D2A4", VA = "0x7BBBE2D2A4", Slot = "24")]
		public override void AfterScreenshot()
		{
		}

		// Token: 0x0600977C RID: 38780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600977C")]
		[Address(RVA = "0x162D30C", Offset = "0x162D30C", VA = "0x7BBBE2D30C")]
		public UISeasonStatsDetailController()
		{
		}

		// Token: 0x04009F98 RID: 40856
		[Token(Token = "0x4009F98")]
		[FieldOffset(Offset = "0xB0")]
		private UISeasonStatsDetailView m_View;

		// Token: 0x04009F99 RID: 40857
		[Token(Token = "0x4009F99")]
		[FieldOffset(Offset = "0xB8")]
		private GameObject[] m_CSStarArray;

		// Token: 0x04009F9A RID: 40858
		[Token(Token = "0x4009F9A")]
		[FieldOffset(Offset = "0xC0")]
		private GameObject[] m_CSBlackStarArray;
	}
}
