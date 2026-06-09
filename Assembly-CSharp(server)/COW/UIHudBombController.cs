using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200187F RID: 6271
	[Token(Token = "0x200187F")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F431C", Offset = "0x10F431C")]
	internal class UIHudBombController : UIHudButtonBaseController
	{
		// Token: 0x06007BF5 RID: 31733 RVA: 0x00022128 File Offset: 0x00020328
		[Token(Token = "0x6007BF5")]
		[Address(RVA = "0x1896134", Offset = "0x1896134", VA = "0x7BBC096134")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007BF6 RID: 31734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BF6")]
		[Address(RVA = "0x1896184", Offset = "0x1896184", VA = "0x7BBC096184", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007BF7 RID: 31735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BF7")]
		[Address(RVA = "0x18964E4", Offset = "0x18964E4", VA = "0x7BBC0964E4", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06007BF8 RID: 31736 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007BF8")]
		[Address(RVA = "0x18967FC", Offset = "0x18967FC", VA = "0x7BBC0967FC", Slot = "33")]
		protected override string GetMappingName()
		{
			return null;
		}

		// Token: 0x06007BF9 RID: 31737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BF9")]
		[Address(RVA = "0x1896844", Offset = "0x1896844", VA = "0x7BBC096844")]
		public void SetBombButtonStatus(bool isAttackSide)
		{
		}

		// Token: 0x06007BFA RID: 31738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BFA")]
		[Address(RVA = "0x18969D4", Offset = "0x18969D4", VA = "0x7BBC0969D4")]
		public void OnEnterBombArea(params object[] param)
		{
		}

		// Token: 0x06007BFB RID: 31739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BFB")]
		[Address(RVA = "0x1896BE4", Offset = "0x1896BE4", VA = "0x7BBC096BE4")]
		public void OnEnterBombLevelObject(params object[] param)
		{
		}

		// Token: 0x06007BFC RID: 31740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BFC")]
		[Address(RVA = "0x1896DB8", Offset = "0x1896DB8", VA = "0x7BBC096DB8")]
		public void OnPreparationStart(params object[] data)
		{
		}

		// Token: 0x06007BFD RID: 31741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BFD")]
		[Address(RVA = "0x1896DC8", Offset = "0x1896DC8", VA = "0x7BBC096DC8")]
		public void OnPreparationCancel(params object[] data)
		{
		}

		// Token: 0x06007BFE RID: 31742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BFE")]
		[Address(RVA = "0x1896DEC", Offset = "0x1896DEC", VA = "0x7BBC096DEC")]
		public void OnPreparationEnd(params object[] data)
		{
		}

		// Token: 0x06007BFF RID: 31743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BFF")]
		[Address(RVA = "0x1896E00", Offset = "0x1896E00", VA = "0x7BBC096E00")]
		public void OnPlayerInvBombCountChange(params object[] data)
		{
		}

		// Token: 0x06007C00 RID: 31744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C00")]
		[Address(RVA = "0x1897008", Offset = "0x1897008", VA = "0x7BBC097008")]
		public void OnRoundChange(params object[] data)
		{
		}

		// Token: 0x06007C01 RID: 31745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C01")]
		[Address(RVA = "0x1897038", Offset = "0x1897038", VA = "0x7BBC097038")]
		public void OnMustHideBombButton(params object[] data)
		{
		}

		// Token: 0x06007C02 RID: 31746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C02")]
		[Address(RVA = "0x189706C", Offset = "0x189706C", VA = "0x7BBC09706C")]
		public UIHudBombController()
		{
		}

		// Token: 0x0400902F RID: 36911
		[Token(Token = "0x400902F")]
		[FieldOffset(Offset = "0x60")]
		private UIHudBombView m_View;

		// Token: 0x04009030 RID: 36912
		[Token(Token = "0x4009030")]
		[FieldOffset(Offset = "0x68")]
		private string PlantBombIcon;

		// Token: 0x04009031 RID: 36913
		[Token(Token = "0x4009031")]
		[FieldOffset(Offset = "0x70")]
		private string RemoveBombIcon;

		// Token: 0x04009032 RID: 36914
		[Token(Token = "0x4009032")]
		[FieldOffset(Offset = "0x78")]
		private string PlantBombHintLocTxt;

		// Token: 0x04009033 RID: 36915
		[Token(Token = "0x4009033")]
		[FieldOffset(Offset = "0x80")]
		private string RemoveBombHintLocTxt;

		// Token: 0x04009034 RID: 36916
		[Token(Token = "0x4009034")]
		[FieldOffset(Offset = "0x88")]
		private bool m_NeedShow;

		// Token: 0x04009035 RID: 36917
		[Token(Token = "0x4009035")]
		[FieldOffset(Offset = "0x89")]
		private bool m_MustHide;
	}
}
