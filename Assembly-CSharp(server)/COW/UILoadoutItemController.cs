using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x020019E6 RID: 6630
	[Token(Token = "0x20019E6")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F733C", Offset = "0x10F733C")]
	internal class UILoadoutItemController : UIBaseController
	{
		// Token: 0x0600890D RID: 35085 RVA: 0x00024DC8 File Offset: 0x00022FC8
		[Token(Token = "0x600890D")]
		[Address(RVA = "0x1520848", Offset = "0x1520848", VA = "0x7BBBD20848")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600890E RID: 35086 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600890E")]
		[Address(RVA = "0x1520898", Offset = "0x1520898", VA = "0x7BBBD20898", Slot = "28")]
		public virtual UIWidget GetWidget()
		{
			return null;
		}

		// Token: 0x0600890F RID: 35087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600890F")]
		[Address(RVA = "0x15208C4", Offset = "0x15208C4", VA = "0x7BBBD208C4", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008910 RID: 35088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008910")]
		[Address(RVA = "0x1520F54", Offset = "0x1520F54", VA = "0x7BBBD20F54")]
		public void ShowNewbieGuide(bool show)
		{
		}

		// Token: 0x06008911 RID: 35089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008911")]
		[Address(RVA = "0x1521184", Offset = "0x1521184", VA = "0x7BBBD21184")]
		private void OnInfoBtnClicked()
		{
		}

		// Token: 0x06008912 RID: 35090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008912")]
		[Address(RVA = "0x1521360", Offset = "0x1521360", VA = "0x7BBBD21360")]
		private void ToggleInfoText()
		{
		}

		// Token: 0x06008913 RID: 35091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008913")]
		[Address(RVA = "0x1521518", Offset = "0x1521518", VA = "0x7BBBD21518")]
		private void OnIncreaseClicked()
		{
		}

		// Token: 0x06008914 RID: 35092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008914")]
		[Address(RVA = "0x1521670", Offset = "0x1521670", VA = "0x7BBBD21670")]
		private void OnDecreaseClicked()
		{
		}

		// Token: 0x06008915 RID: 35093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008915")]
		[Address(RVA = "0x1520DC8", Offset = "0x1520DC8", VA = "0x7BBBD20DC8")]
		protected void ShowBuyInfo(bool val)
		{
		}

		// Token: 0x06008916 RID: 35094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008916")]
		[Address(RVA = "0x1521594", Offset = "0x1521594", VA = "0x7BBBD21594")]
		private void RefreshBuyInfo()
		{
		}

		// Token: 0x06008917 RID: 35095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008917")]
		[Address(RVA = "0x15216EC", Offset = "0x15216EC", VA = "0x7BBBD216EC")]
		private void OnBtnClicked()
		{
		}

		// Token: 0x06008918 RID: 35096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008918")]
		[Address(RVA = "0x1521AF4", Offset = "0x1521AF4", VA = "0x7BBBD21AF4")]
		public void SetData(BaseItemInfo item, int index)
		{
		}

		// Token: 0x06008919 RID: 35097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008919")]
		[Address(RVA = "0x1521C9C", Offset = "0x1521C9C", VA = "0x7BBBD21C9C")]
		public void RefreshUI()
		{
		}

		// Token: 0x0600891A RID: 35098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600891A")]
		[Address(RVA = "0x1520C30", Offset = "0x1520C30", VA = "0x7BBBD20C30")]
		public void SetSelected(bool v)
		{
		}

		// Token: 0x0600891B RID: 35099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600891B")]
		[Address(RVA = "0x15224CC", Offset = "0x15224CC", VA = "0x7BBBD224CC")]
		private void OnBuyClick()
		{
		}

		// Token: 0x0600891C RID: 35100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600891C")]
		[Address(RVA = "0x1522380", Offset = "0x1522380", VA = "0x7BBBD22380")]
		protected void RefreshPlayCardTime()
		{
		}

		// Token: 0x0600891D RID: 35101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600891D")]
		[Address(RVA = "0x1520F0C", Offset = "0x1520F0C", VA = "0x7BBBD20F0C")]
		protected void ShowPlayCardInfo(bool val)
		{
		}

		// Token: 0x0600891E RID: 35102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600891E")]
		[Address(RVA = "0x15225AC", Offset = "0x15225AC", VA = "0x7BBBD225AC")]
		public void Update()
		{
		}

		// Token: 0x0600891F RID: 35103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600891F")]
		[Address(RVA = "0x15226C0", Offset = "0x15226C0", VA = "0x7BBBD226C0")]
		public UILoadoutItemController()
		{
		}

		// Token: 0x04009739 RID: 38713
		[Token(Token = "0x4009739")]
		[FieldOffset(Offset = "0x58")]
		private UILoadOutItemView m_View;

		// Token: 0x0400973A RID: 38714
		[Token(Token = "0x400973A")]
		[FieldOffset(Offset = "0x60")]
		public int ItemIdex;

		// Token: 0x0400973B RID: 38715
		[Token(Token = "0x400973B")]
		[FieldOffset(Offset = "0x68")]
		public BaseItemInfo LoadOutData;

		// Token: 0x0400973C RID: 38716
		[Token(Token = "0x400973C")]
		[FieldOffset(Offset = "0x70")]
		public Item PlayCardData;

		// Token: 0x0400973D RID: 38717
		[Token(Token = "0x400973D")]
		[FieldOffset(Offset = "0x78")]
		public CSSharedItemDataManager.LoadoutSubType LoadOutType;

		// Token: 0x0400973E RID: 38718
		[Token(Token = "0x400973E")]
		[FieldOffset(Offset = "0x80")]
		public StoreDesc LoadoutStoreInfo;

		// Token: 0x0400973F RID: 38719
		[Token(Token = "0x400973F")]
		[FieldOffset(Offset = "0x88")]
		public int BuyCount;

		// Token: 0x04009740 RID: 38720
		[Token(Token = "0x4009740")]
		[FieldOffset(Offset = "0x8C")]
		protected bool m_selected;

		// Token: 0x04009741 RID: 38721
		[Token(Token = "0x4009741")]
		[FieldOffset(Offset = "0x90")]
		private TweenAlpha m_GuideAlpha;

		// Token: 0x04009742 RID: 38722
		[Token(Token = "0x4009742")]
		[FieldOffset(Offset = "0x98")]
		private UISprite m_HLSprite;

		// Token: 0x04009743 RID: 38723
		[Token(Token = "0x4009743")]
		[FieldOffset(Offset = "0xA0")]
		protected List<string> LoadoutTutorialTitles;
	}
}
