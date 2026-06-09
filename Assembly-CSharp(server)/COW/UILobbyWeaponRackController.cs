using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001A20 RID: 6688
	[Token(Token = "0x2001A20")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F7914", Offset = "0x10F7914")]
	public class UILobbyWeaponRackController : UINavigationController, IEasyList
	{
		// Token: 0x06008C08 RID: 35848 RVA: 0x00025668 File Offset: 0x00023868
		[Token(Token = "0x6008C08")]
		[Address(RVA = "0x19DC600", Offset = "0x19DC600", VA = "0x7BBC1DC600")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008C09 RID: 35849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C09")]
		[Address(RVA = "0x19DC650", Offset = "0x19DC650", VA = "0x7BBC1DC650", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008C0A RID: 35850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C0A")]
		[Address(RVA = "0x19DC6B4", Offset = "0x19DC6B4", VA = "0x7BBC1DC6B4", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x06008C0B RID: 35851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C0B")]
		[Address(RVA = "0x19DC6BC", Offset = "0x19DC6BC", VA = "0x7BBC1DC6BC", Slot = "28")]
		public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
		{
		}

		// Token: 0x06008C0C RID: 35852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C0C")]
		[Address(RVA = "0x19DC6C8", Offset = "0x19DC6C8", VA = "0x7BBC1DC6C8", Slot = "29")]
		public override void OnNavigationClosed()
		{
		}

		// Token: 0x06008C0D RID: 35853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C0D")]
		[Address(RVA = "0x19DC6D0", Offset = "0x19DC6D0", VA = "0x7BBC1DC6D0", Slot = "38")]
		protected override void OnHelpButtonClick(params object[] param)
		{
		}

		// Token: 0x06008C0E RID: 35854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C0E")]
		[Address(RVA = "0x19DC7EC", Offset = "0x19DC7EC", VA = "0x7BBC1DC7EC")]
		private void ProcessCollectionData()
		{
		}

		// Token: 0x06008C0F RID: 35855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C0F")]
		[Address(RVA = "0x19DC7F0", Offset = "0x19DC7F0", VA = "0x7BBC1DC7F0")]
		private void RefreshWeaponList(List<WeaponSkinBaseInfo> weaponList)
		{
		}

		// Token: 0x06008C10 RID: 35856 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6008C10")]
		[Address(RVA = "0x19DCAB4", Offset = "0x19DCAB4", VA = "0x7BBC1DCAB4", Slot = "39")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x06008C11 RID: 35857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C11")]
		[Address(RVA = "0x19DCB70", Offset = "0x19DCB70", VA = "0x7BBC1DCB70", Slot = "40")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x06008C12 RID: 35858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C12")]
		[Address(RVA = "0x19DCBA0", Offset = "0x19DCBA0", VA = "0x7BBC1DCBA0")]
		private void GenerateWeaponTypeFilterData()
		{
		}

		// Token: 0x06008C13 RID: 35859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C13")]
		[Address(RVA = "0x19DD01C", Offset = "0x19DD01C", VA = "0x7BBC1DD01C")]
		private void OnWeaponTypeFilterItemClick(object data)
		{
		}

		// Token: 0x06008C14 RID: 35860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C14")]
		[Address(RVA = "0x19DD3BC", Offset = "0x19DD3BC", VA = "0x7BBC1DD3BC")]
		private void GenerateQualityPopData()
		{
		}

		// Token: 0x06008C15 RID: 35861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C15")]
		[Address(RVA = "0x19DD908", Offset = "0x19DD908", VA = "0x7BBC1DD908")]
		private void OnQualityItemClick(object data)
		{
		}

		// Token: 0x06008C16 RID: 35862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C16")]
		[Address(RVA = "0x19DD21C", Offset = "0x19DD21C", VA = "0x7BBC1DD21C")]
		private void RefreshAllWeapons()
		{
		}

		// Token: 0x06008C17 RID: 35863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C17")]
		[Address(RVA = "0x19DDB74", Offset = "0x19DDB74", VA = "0x7BBC1DDB74")]
		private void OnDragStart(object[] data)
		{
		}

		// Token: 0x06008C18 RID: 35864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C18")]
		[Address(RVA = "0x19DDBB8", Offset = "0x19DDBB8", VA = "0x7BBC1DDBB8")]
		public UILobbyWeaponRackController()
		{
		}

		// Token: 0x040098BA RID: 39098
		[Token(Token = "0x40098BA")]
		private const string UILobbyWeaponRackNewGuideKey = "UILOBBYWEAPONRACKNEWGUIDEKEY";

		// Token: 0x040098BB RID: 39099
		[Token(Token = "0x40098BB")]
		[FieldOffset(Offset = "0xB0")]
		private UILobbyWeaponRackView m_View;

		// Token: 0x040098BC RID: 39100
		[Token(Token = "0x40098BC")]
		[FieldOffset(Offset = "0xB8")]
		private UIModelWeaponRack m_ModelRack;

		// Token: 0x040098BD RID: 39101
		[Token(Token = "0x40098BD")]
		[FieldOffset(Offset = "0xC0")]
		private UIPopMenuSmallControler m_PopMenuGun;

		// Token: 0x040098BE RID: 39102
		[Token(Token = "0x40098BE")]
		[FieldOffset(Offset = "0xC8")]
		private UIPopMenuSmallControler m_PopMenuRare;

		// Token: 0x040098BF RID: 39103
		[Token(Token = "0x40098BF")]
		[FieldOffset(Offset = "0xD0")]
		private uint m_CurrentSelectWeaponID;

		// Token: 0x040098C0 RID: 39104
		[Token(Token = "0x40098C0")]
		[FieldOffset(Offset = "0xD4")]
		private CollectionDataManager.ECollectionWeaponType m_CurrentFilterWeaponType;

		// Token: 0x040098C1 RID: 39105
		[Token(Token = "0x40098C1")]
		[FieldOffset(Offset = "0xD8")]
		private UIModelCollection m_ModelCollection;

		// Token: 0x040098C2 RID: 39106
		[Token(Token = "0x40098C2")]
		[FieldOffset(Offset = "0xE0")]
		private List<PopMenuData> m_WeaponTypeFilterPopMenuList;

		// Token: 0x040098C3 RID: 39107
		[Token(Token = "0x40098C3")]
		[FieldOffset(Offset = "0xE8")]
		private List<PopMenuData> m_WeaponRareFilterPopMenuList;

		// Token: 0x040098C4 RID: 39108
		[Token(Token = "0x40098C4")]
		[FieldOffset(Offset = "0xF0")]
		private List<WeaponRackItemData> m_CurrentListBeforeQuality;

		// Token: 0x040098C5 RID: 39109
		[Token(Token = "0x40098C5")]
		[FieldOffset(Offset = "0xF8")]
		private List<WeaponRackItemData> m_CurrentListAfterQuality;

		// Token: 0x040098C6 RID: 39110
		[Token(Token = "0x40098C6")]
		[FieldOffset(Offset = "0x100")]
		private Dictionary<CollectionDataManager.ECollectionWeaponType, List<WeaponSkinBaseInfo>> WeaponSkinBaseInfoDic;

		// Token: 0x040098C7 RID: 39111
		[Token(Token = "0x40098C7")]
		[FieldOffset(Offset = "0x108")]
		private Dictionary<CollectionDataManager.ECollectionWeaponType, List<uint>> m_WeaponDataList;

		// Token: 0x040098C8 RID: 39112
		[Token(Token = "0x40098C8")]
		[FieldOffset(Offset = "0x110")]
		private List<CollectionDataManager.ECollectionWeaponType> m_WeaponTypeList;

		// Token: 0x040098C9 RID: 39113
		[Token(Token = "0x40098C9")]
		private const string DEFAULTWEAPONTYPE = "T_15_Q_LIVE_ALL";

		// Token: 0x040098CA RID: 39114
		[Token(Token = "0x40098CA")]
		[FieldOffset(Offset = "0x118")]
		private Dictionary<CollectionDataManager.ECollectionWeaponType, string> m_DictWeaponType2Text;

		// Token: 0x02001A21 RID: 6689
		[Token(Token = "0x2001A21")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F794C", Offset = "0x10F794C")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06008C1A RID: 35866 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008C1A")]
			[Address(RVA = "0x19DE184", Offset = "0x19DE184", VA = "0x7BBC1DE184")]
			public <>c()
			{
			}

			// Token: 0x06008C1B RID: 35867 RVA: 0x00025680 File Offset: 0x00023880
			[Token(Token = "0x6008C1B")]
			[Address(RVA = "0x19DE18C", Offset = "0x19DE18C", VA = "0x7BBC1DE18C")]
			internal int <RefreshWeaponList>b__24_0(WeaponRackItemData a, WeaponRackItemData b)
			{
				return 0;
			}

			// Token: 0x040098CB RID: 39115
			[Token(Token = "0x40098CB")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UILobbyWeaponRackController.<>c <>9;

			// Token: 0x040098CC RID: 39116
			[Token(Token = "0x40098CC")]
			[FieldOffset(Offset = "0x8")]
			public static Comparison<WeaponRackItemData> <>9__24_0;
		}
	}
}
