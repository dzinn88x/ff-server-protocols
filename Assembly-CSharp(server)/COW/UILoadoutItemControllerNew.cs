using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x020019E7 RID: 6631
	[Token(Token = "0x20019E7")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F7374", Offset = "0x10F7374")]
	internal class UILoadoutItemControllerNew : UILoadoutItemController
	{
		// Token: 0x06008920 RID: 35104 RVA: 0x00024DE0 File Offset: 0x00022FE0
		[Token(Token = "0x6008920")]
		[Address(RVA = "0x1522730", Offset = "0x1522730", VA = "0x7BBBD22730")]
		public new static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008921 RID: 35105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008921")]
		[Address(RVA = "0x1522780", Offset = "0x1522780", VA = "0x7BBBD22780", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008922 RID: 35106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6008922")]
		[Address(RVA = "0x15229E4", Offset = "0x15229E4", VA = "0x7BBBD229E4", Slot = "28")]
		public override UIWidget GetWidget()
		{
			return null;
		}

		// Token: 0x06008923 RID: 35107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008923")]
		[Address(RVA = "0x1522A10", Offset = "0x1522A10", VA = "0x7BBBD22A10")]
		private void OnInfoBtnClicked()
		{
		}

		// Token: 0x06008924 RID: 35108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008924")]
		[Address(RVA = "0x1522BEC", Offset = "0x1522BEC", VA = "0x7BBBD22BEC")]
		private void ToggleInfoText()
		{
		}

		// Token: 0x06008925 RID: 35109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008925")]
		[Address(RVA = "0x1522DA4", Offset = "0x1522DA4", VA = "0x7BBBD22DA4")]
		private void OnBtnClicked()
		{
		}

		// Token: 0x06008926 RID: 35110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008926")]
		[Address(RVA = "0x1523324", Offset = "0x1523324", VA = "0x7BBBD23324")]
		private void OnIncreaseClicked()
		{
		}

		// Token: 0x06008927 RID: 35111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008927")]
		[Address(RVA = "0x152347C", Offset = "0x152347C", VA = "0x7BBBD2347C")]
		private void OnDecreaseClicked()
		{
		}

		// Token: 0x06008928 RID: 35112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008928")]
		[Address(RVA = "0x15233A0", Offset = "0x15233A0", VA = "0x7BBBD233A0")]
		private void RefreshBuyInfo()
		{
		}

		// Token: 0x06008929 RID: 35113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008929")]
		[Address(RVA = "0x15234F8", Offset = "0x15234F8", VA = "0x7BBBD234F8")]
		private void OnBuyClick()
		{
		}

		// Token: 0x0600892A RID: 35114 RVA: 0x00024DF8 File Offset: 0x00022FF8
		[Token(Token = "0x600892A")]
		[Address(RVA = "0x15235D8", Offset = "0x15235D8", VA = "0x7BBBD235D8")]
		private bool IsItemShow(Item item)
		{
			return default(bool);
		}

		// Token: 0x0600892B RID: 35115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600892B")]
		[Address(RVA = "0x15237D0", Offset = "0x15237D0", VA = "0x7BBBD237D0")]
		public UILoadoutItemControllerNew()
		{
		}

		// Token: 0x04009744 RID: 38724
		[Token(Token = "0x4009744")]
		[FieldOffset(Offset = "0xA8")]
		private UILoadOutItemNewView m_View;
	}
}
