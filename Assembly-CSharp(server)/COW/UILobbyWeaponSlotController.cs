using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001523 RID: 5411
	[Token(Token = "0x2001523")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EE234", Offset = "0x10EE234")]
	public class UILobbyWeaponSlotController : UIBaseController, IUIModelDataChangeObserver
	{
		// Token: 0x06005CEF RID: 23791 RVA: 0x0001B060 File Offset: 0x00019260
		[Token(Token = "0x6005CEF")]
		[Address(RVA = "0x19DF8B0", Offset = "0x19DF8B0", VA = "0x7BBC1DF8B0")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005CF0 RID: 23792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CF0")]
		[Address(RVA = "0x19DF900", Offset = "0x19DF900", VA = "0x7BBC1DF900", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005CF1 RID: 23793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CF1")]
		[Address(RVA = "0x19DF964", Offset = "0x19DF964", VA = "0x7BBC1DF964", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06005CF2 RID: 23794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CF2")]
		[Address(RVA = "0x19DF96C", Offset = "0x19DF96C", VA = "0x7BBC1DF96C")]
		public void SetViewData(int slot, uint weaponID)
		{
		}

		// Token: 0x06005CF3 RID: 23795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CF3")]
		[Address(RVA = "0x19DFC6C", Offset = "0x19DFC6C", VA = "0x7BBC1DFC6C")]
		public void SendCreateEvent(WeaponSkinBaseInfo info)
		{
		}

		// Token: 0x06005CF4 RID: 23796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CF4")]
		[Address(RVA = "0x19DFCEC", Offset = "0x19DFCEC", VA = "0x7BBC1DFCEC")]
		public void OnDragOver()
		{
		}

		// Token: 0x06005CF5 RID: 23797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CF5")]
		[Address(RVA = "0x19DFE38", Offset = "0x19DFE38", VA = "0x7BBC1DFE38")]
		public void OnDragOut()
		{
		}

		// Token: 0x06005CF6 RID: 23798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CF6")]
		[Address(RVA = "0x19DFA7C", Offset = "0x19DFA7C", VA = "0x7BBC1DFA7C")]
		private void SetCloneObject()
		{
		}

		// Token: 0x06005CF7 RID: 23799 RVA: 0x0001B078 File Offset: 0x00019278
		[Token(Token = "0x6005CF7")]
		[Address(RVA = "0x19DFF80", Offset = "0x19DFF80", VA = "0x7BBC1DFF80")]
		public bool HasWeaponInSlot()
		{
			return default(bool);
		}

		// Token: 0x06005CF8 RID: 23800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CF8")]
		[Address(RVA = "0x19DFF90", Offset = "0x19DFF90", VA = "0x7BBC1DFF90", Slot = "28")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06005CF9 RID: 23801 RVA: 0x0001B090 File Offset: 0x00019290
		[Token(Token = "0x6005CF9")]
		[Address(RVA = "0x19E0058", Offset = "0x19E0058", VA = "0x7BBC1E0058", Slot = "29")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06005CFA RID: 23802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CFA")]
		[Address(RVA = "0x19E009C", Offset = "0x19E009C", VA = "0x7BBC1E009C")]
		public UILobbyWeaponSlotController()
		{
		}

		// Token: 0x04007ED1 RID: 32465
		[Token(Token = "0x4007ED1")]
		[FieldOffset(Offset = "0x58")]
		private int m_Slot;

		// Token: 0x04007ED2 RID: 32466
		[Token(Token = "0x4007ED2")]
		[FieldOffset(Offset = "0x60")]
		private UILobbyWeaponSlotView m_view;

		// Token: 0x04007ED3 RID: 32467
		[Token(Token = "0x4007ED3")]
		[FieldOffset(Offset = "0x68")]
		private WeaponSkinBaseInfo m_ItemData;

		// Token: 0x04007ED4 RID: 32468
		[Token(Token = "0x4007ED4")]
		[FieldOffset(Offset = "0x70")]
		private UIModelWeaponRack m_Data;

		// Token: 0x04007ED5 RID: 32469
		[Token(Token = "0x4007ED5")]
		[FieldOffset(Offset = "0x78")]
		private bool m_IsDragOver;

		// Token: 0x04007ED6 RID: 32470
		[Token(Token = "0x4007ED6")]
		private const string CLOSEKEY = "HDWeaponSlot";
	}
}
