using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001A22 RID: 6690
	[Token(Token = "0x2001A22")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F795C", Offset = "0x10F795C")]
	public class UILobbyWeaponRackItemController : UIEasyListItemController, IUIModelDataChangeObserver
	{
		// Token: 0x06008C1C RID: 35868 RVA: 0x00025698 File Offset: 0x00023898
		[Token(Token = "0x6008C1C")]
		[Address(RVA = "0x19DE1C4", Offset = "0x19DE1C4", VA = "0x7BBC1DE1C4")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008C1D RID: 35869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C1D")]
		[Address(RVA = "0x19DE214", Offset = "0x19DE214", VA = "0x7BBC1DE214", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008C1E RID: 35870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C1E")]
		[Address(RVA = "0x19DE444", Offset = "0x19DE444", VA = "0x7BBC1DE444", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x06008C1F RID: 35871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C1F")]
		[Address(RVA = "0x19DE598", Offset = "0x19DE598", VA = "0x7BBC1DE598", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x06008C20 RID: 35872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C20")]
		[Address(RVA = "0x19DEB60", Offset = "0x19DEB60", VA = "0x7BBC1DEB60")]
		private void SetQualityBG(int Quality)
		{
		}

		// Token: 0x06008C21 RID: 35873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C21")]
		[Address(RVA = "0x19DED68", Offset = "0x19DED68", VA = "0x7BBC1DED68")]
		private void OnDragOverTrigger(object[] data)
		{
		}

		// Token: 0x06008C22 RID: 35874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C22")]
		[Address(RVA = "0x19DEDA8", Offset = "0x19DEDA8", VA = "0x7BBC1DEDA8", Slot = "31")]
		public override void OnItemBtnSelect()
		{
		}

		// Token: 0x06008C23 RID: 35875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C23")]
		[Address(RVA = "0x19DEDF8", Offset = "0x19DEDF8", VA = "0x7BBC1DEDF8", Slot = "32")]
		public override void OnItemBtnUnSelect()
		{
		}

		// Token: 0x06008C24 RID: 35876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C24")]
		[Address(RVA = "0x19DEE48", Offset = "0x19DEE48", VA = "0x7BBC1DEE48", Slot = "34")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06008C25 RID: 35877 RVA: 0x000256B0 File Offset: 0x000238B0
		[Token(Token = "0x6008C25")]
		[Address(RVA = "0x19DF0DC", Offset = "0x19DF0DC", VA = "0x7BBC1DF0DC", Slot = "35")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06008C26 RID: 35878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C26")]
		[Address(RVA = "0x19DF120", Offset = "0x19DF120", VA = "0x7BBC1DF120")]
		public UILobbyWeaponRackItemController()
		{
		}

		// Token: 0x06008C27 RID: 35879 RVA: 0x000256C8 File Offset: 0x000238C8
		[Token(Token = "0x6008C27")]
		[Address(RVA = "0x19DF128", Offset = "0x19DF128", VA = "0x7BBC1DF128")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1144274", Offset = "0x1144274")]
		private bool <SetViewData>b__5_0(uint x)
		{
			return default(bool);
		}

		// Token: 0x06008C28 RID: 35880 RVA: 0x000256E0 File Offset: 0x000238E0
		[Token(Token = "0x6008C28")]
		[Address(RVA = "0x19DF180", Offset = "0x19DF180", VA = "0x7BBC1DF180")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1144284", Offset = "0x1144284")]
		private bool <OnDataChanged>b__10_0(uint x)
		{
			return default(bool);
		}

		// Token: 0x040098CD RID: 39117
		[Token(Token = "0x40098CD")]
		[FieldOffset(Offset = "0x70")]
		private UILobbyWeaponRackItemView m_View;

		// Token: 0x040098CE RID: 39118
		[Token(Token = "0x40098CE")]
		[FieldOffset(Offset = "0x78")]
		private WeaponRackItemData m_Itemdata;
	}
}
