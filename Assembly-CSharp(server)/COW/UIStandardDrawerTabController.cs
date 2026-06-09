using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200166D RID: 5741
	[Token(Token = "0x200166D")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F00FC", Offset = "0x10F00FC")]
	public class UIStandardDrawerTabController : UIBaseController
	{
		// Token: 0x060067E2 RID: 26594 RVA: 0x0001D880 File Offset: 0x0001BA80
		[Token(Token = "0x60067E2")]
		[Address(RVA = "0x163C6F0", Offset = "0x163C6F0", VA = "0x7BBBE3C6F0")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060067E3 RID: 26595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60067E3")]
		[Address(RVA = "0x163C740", Offset = "0x163C740", VA = "0x7BBBE3C740", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060067E4 RID: 26596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60067E4")]
		[Address(RVA = "0x163C804", Offset = "0x163C804", VA = "0x7BBBE3C804")]
		public void CreateTabByData(StandardTabItemViewData mainTabData, List<StandardSubTabItemViewData> subTabDataist)
		{
		}

		// Token: 0x060067E5 RID: 26597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60067E5")]
		[Address(RVA = "0x163C9DC", Offset = "0x163C9DC", VA = "0x7BBBE3C9DC")]
		public void SelectSubTabByIndex(int mainTabIndex, int subTabIndex)
		{
		}

		// Token: 0x060067E6 RID: 26598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60067E6")]
		[Address(RVA = "0x163CCD0", Offset = "0x163CCD0", VA = "0x7BBBE3CCD0")]
		private void UpdateScrollViewState()
		{
		}

		// Token: 0x060067E7 RID: 26599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60067E7")]
		[Address(RVA = "0x163CE70", Offset = "0x163CE70", VA = "0x7BBBE3CE70")]
		public void ReposTab()
		{
		}

		// Token: 0x060067E8 RID: 26600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067E8")]
		[Address(RVA = "0x163CC28", Offset = "0x163CC28", VA = "0x7BBBE3CC28")]
		public UIStandardTabItemController GetTabItemControllerByIndex(int index)
		{
			return null;
		}

		// Token: 0x060067E9 RID: 26601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60067E9")]
		[Address(RVA = "0x163CA34", Offset = "0x163CA34", VA = "0x7BBBE3CA34")]
		public void SelectMainTabByIndex(int index, bool isDrawerOpen = false)
		{
		}

		// Token: 0x060067EA RID: 26602 RVA: 0x0001D898 File Offset: 0x0001BA98
		[Token(Token = "0x60067EA")]
		[Address(RVA = "0x163CEB4", Offset = "0x163CEB4", VA = "0x7BBBE3CEB4")]
		public int GetCurTabItemIndex()
		{
			return 0;
		}

		// Token: 0x060067EB RID: 26603 RVA: 0x0001D8B0 File Offset: 0x0001BAB0
		[Token(Token = "0x60067EB")]
		[Address(RVA = "0x163CEBC", Offset = "0x163CEBC", VA = "0x7BBBE3CEBC")]
		public bool IsMainTabNoSubTabItem(int mainTabIndex)
		{
			return default(bool);
		}

		// Token: 0x060067EC RID: 26604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60067EC")]
		[Address(RVA = "0x163CF44", Offset = "0x163CF44", VA = "0x7BBBE3CF44")]
		public void SetGuideContainerPos(Vector3 pos)
		{
		}

		// Token: 0x060067ED RID: 26605 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067ED")]
		[Address(RVA = "0x163CFC4", Offset = "0x163CFC4", VA = "0x7BBBE3CFC4")]
		public UIWidget GetGuideWidght()
		{
			return null;
		}

		// Token: 0x060067EE RID: 26606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60067EE")]
		[Address(RVA = "0x163CFF0", Offset = "0x163CFF0", VA = "0x7BBBE3CFF0")]
		public UIStandardDrawerTabController()
		{
		}

		// Token: 0x04008501 RID: 34049
		[Token(Token = "0x4008501")]
		[FieldOffset(Offset = "0x58")]
		private UIStandardDrawerTabView m_View;

		// Token: 0x04008502 RID: 34050
		[Token(Token = "0x4008502")]
		[FieldOffset(Offset = "0x60")]
		private List<UIStandardTabItemController> mainTabList;

		// Token: 0x04008503 RID: 34051
		[Token(Token = "0x4008503")]
		[FieldOffset(Offset = "0x68")]
		private int maxMainTabItemIndex;

		// Token: 0x04008504 RID: 34052
		[Token(Token = "0x4008504")]
		[FieldOffset(Offset = "0x6C")]
		private int curMainTabItemIndex;
	}
}
