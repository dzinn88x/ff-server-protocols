using System;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using message;
using UnityEngine;

namespace COW
{
	// Token: 0x02001B86 RID: 7046
	[Token(Token = "0x2001B86")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FA414", Offset = "0x10FA414")]
	public class UISPHudBasePlayerInfoController : UIBaseController, IUIModelDataChangeObserver
	{
		// Token: 0x060097D7 RID: 38871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60097D7")]
		[Address(RVA = "0x1A27A24", Offset = "0x1A27A24", VA = "0x7BBC227A24", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060097D8 RID: 38872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60097D8")]
		[Address(RVA = "0x1A28034", Offset = "0x1A28034", VA = "0x7BBC228034", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060097D9 RID: 38873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60097D9")]
		[Address(RVA = "0x1A28414", Offset = "0x1A28414", VA = "0x7BBC228414")]
		private void OnMAXHPChanged(params object[] data)
		{
		}

		// Token: 0x060097DA RID: 38874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60097DA")]
		[Address(RVA = "0x1A28554", Offset = "0x1A28554", VA = "0x7BBC228554")]
		private void RefreshMAXHP(params object[] data)
		{
		}

		// Token: 0x060097DB RID: 38875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60097DB")]
		[Address(RVA = "0x1A28790", Offset = "0x1A28790", VA = "0x7BBC228790")]
		private void OnHPChanged(params object[] data)
		{
		}

		// Token: 0x060097DC RID: 38876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60097DC")]
		[Address(RVA = "0x1A288D8", Offset = "0x1A288D8", VA = "0x7BBC2288D8")]
		private void RefreshHP(params object[] data)
		{
		}

		// Token: 0x060097DD RID: 38877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60097DD")]
		[Address(RVA = "0x1A28BA4", Offset = "0x1A28BA4", VA = "0x7BBC228BA4")]
		private void OnEPChanged(params object[] data)
		{
		}

		// Token: 0x060097DE RID: 38878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60097DE")]
		[Address(RVA = "0x1A28CE8", Offset = "0x1A28CE8", VA = "0x7BBC228CE8")]
		private void RefreshEP()
		{
		}

		// Token: 0x060097DF RID: 38879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60097DF")]
		[Address(RVA = "0x1A28EA0", Offset = "0x1A28EA0", VA = "0x7BBC228EA0")]
		private void OnKnockDownFlagChange(object[] data)
		{
		}

		// Token: 0x060097E0 RID: 38880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60097E0")]
		[Address(RVA = "0x1A290A4", Offset = "0x1A290A4", VA = "0x7BBC2290A4")]
		private void RefreshEquipmentStats(ByGSUuj InSlot = ByGSUuj.Unknown)
		{
		}

		// Token: 0x060097E1 RID: 38881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60097E1")]
		[Address(RVA = "0x1A2A098", Offset = "0x1A2A098", VA = "0x7BBC22A098")]
		private void OnEnquipmentEquipStateChanged(params object[] InParams)
		{
		}

		// Token: 0x060097E2 RID: 38882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60097E2")]
		[Address(RVA = "0x1A2A220", Offset = "0x1A2A220", VA = "0x7BBC22A220")]
		private void UpdateMedkit()
		{
		}

		// Token: 0x060097E3 RID: 38883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60097E3")]
		[Address(RVA = "0x1A2A3BC", Offset = "0x1A2A3BC", VA = "0x7BBC22A3BC")]
		private void UpdateGrenade()
		{
		}

		// Token: 0x060097E4 RID: 38884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60097E4")]
		[Address(RVA = "0x1A2A558", Offset = "0x1A2A558", VA = "0x7BBC22A558")]
		private void UpdateSmokingBomb()
		{
		}

		// Token: 0x060097E5 RID: 38885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60097E5")]
		[Address(RVA = "0x1A2A6F4", Offset = "0x1A2A6F4", VA = "0x7BBC22A6F4")]
		private void UpdateIceWall()
		{
		}

		// Token: 0x060097E6 RID: 38886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60097E6")]
		[Address(RVA = "0x1A2A890", Offset = "0x1A2A890", VA = "0x7BBC22A890")]
		private void OnItemChanged(params object[] param)
		{
		}

		// Token: 0x060097E7 RID: 38887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60097E7")]
		[Address(RVA = "0x1A2B0C8", Offset = "0x1A2B0C8", VA = "0x7BBC22B0C8")]
		private void OnNewItemOnHand(params object[] param)
		{
		}

		// Token: 0x060097E8 RID: 38888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60097E8")]
		[Address(RVA = "0x1A2AB38", Offset = "0x1A2AB38", VA = "0x7BBC22AB38")]
		private void RefreshItemUI(bool isNewOnHand, HesZZW itemType = HesZZW.EITEM_TYPE_GRENADE)
		{
		}

		// Token: 0x060097E9 RID: 38889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60097E9")]
		[Address(RVA = "0x1A2B480", Offset = "0x1A2B480", VA = "0x7BBC22B480")]
		private void RefreshUIWhenCountChanged(PlayerData data, HesZZW itemType)
		{
		}

		// Token: 0x060097EA RID: 38890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60097EA")]
		[Address(RVA = "0x1A2B1F4", Offset = "0x1A2B1F4", VA = "0x7BBC22B1F4")]
		private void RefreshWeaponUI()
		{
		}

		// Token: 0x060097EB RID: 38891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60097EB")]
		[Address(RVA = "0x1A2B754", Offset = "0x1A2B754", VA = "0x7BBC22B754")]
		private void OnObserverSwitch(object[] data)
		{
		}

		// Token: 0x060097EC RID: 38892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60097EC")]
		[Address(RVA = "0x1A2C2F8", Offset = "0x1A2C2F8", VA = "0x7BBC22C2F8")]
		private void RefreshSkillStatus()
		{
		}

		// Token: 0x060097ED RID: 38893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60097ED")]
		[Address(RVA = "0x1A2C81C", Offset = "0x1A2C81C", VA = "0x7BBC22C81C")]
		private void SetBgColor(UISprite sp, char type, float alpha)
		{
		}

		// Token: 0x060097EE RID: 38894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60097EE")]
		[Address(RVA = "0x1A2C970", Offset = "0x1A2C970", VA = "0x7BBC22C970")]
		private void OnSkillIconToggle(params object[] data)
		{
		}

		// Token: 0x060097EF RID: 38895 RVA: 0x00028050 File Offset: 0x00026250
		[Token(Token = "0x60097EF")]
		[Address(RVA = "0x1A2CAC4", Offset = "0x1A2CAC4", VA = "0x7BBC22CAC4", Slot = "29")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x060097F0 RID: 38896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60097F0")]
		[Address(RVA = "0x1A2CB08", Offset = "0x1A2CB08", VA = "0x7BBC22CB08", Slot = "28")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x060097F1 RID: 38897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60097F1")]
		[Address(RVA = "0x1A2C0BC", Offset = "0x1A2C0BC", VA = "0x7BBC22C0BC")]
		private void RefreshLabelKill()
		{
		}

		// Token: 0x060097F2 RID: 38898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60097F2")]
		[Address(RVA = "0x1A2CF34", Offset = "0x1A2CF34", VA = "0x7BBC22CF34")]
		private void OnAttachmentChanged(params object[] param)
		{
		}

		// Token: 0x060097F3 RID: 38899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60097F3")]
		[Address(RVA = "0x1A2D0AC", Offset = "0x1A2D0AC", VA = "0x7BBC22D0AC")]
		public UISPHudBasePlayerInfoController()
		{
		}

		// Token: 0x04009FD6 RID: 40918
		[Token(Token = "0x4009FD6")]
		[FieldOffset(Offset = "0x58")]
		protected SPHudPlayerInfoType m_Type;

		// Token: 0x04009FD7 RID: 40919
		[Token(Token = "0x4009FD7")]
		[FieldOffset(Offset = "0x60")]
		protected UISPHudNewPlayerInfoView m_View;

		// Token: 0x04009FD8 RID: 40920
		[Token(Token = "0x4009FD8")]
		[FieldOffset(Offset = "0x68")]
		protected UISPHudCSPlayerInfoView m_CSView;

		// Token: 0x04009FD9 RID: 40921
		[Token(Token = "0x4009FD9")]
		[FieldOffset(Offset = "0x70")]
		protected GameObject EPNode;

		// Token: 0x04009FDA RID: 40922
		[Token(Token = "0x4009FDA")]
		[FieldOffset(Offset = "0x78")]
		protected UISprite EPBar;

		// Token: 0x04009FDB RID: 40923
		[Token(Token = "0x4009FDB")]
		[FieldOffset(Offset = "0x80")]
		protected UILabel LabelHP;

		// Token: 0x04009FDC RID: 40924
		[Token(Token = "0x4009FDC")]
		[FieldOffset(Offset = "0x88")]
		protected UISprite HPBar;

		// Token: 0x04009FDD RID: 40925
		[Token(Token = "0x4009FDD")]
		[FieldOffset(Offset = "0x90")]
		protected UISprite TeamFakeIcon;

		// Token: 0x04009FDE RID: 40926
		[Token(Token = "0x4009FDE")]
		[FieldOffset(Offset = "0x98")]
		protected UIEffectSprite TeamIcon;

		// Token: 0x04009FDF RID: 40927
		[Token(Token = "0x4009FDF")]
		[FieldOffset(Offset = "0xA0")]
		protected UIEffectSprite FlagIcon;

		// Token: 0x04009FE0 RID: 40928
		[Token(Token = "0x4009FE0")]
		[FieldOffset(Offset = "0xA8")]
		protected UILabel TeamId;

		// Token: 0x04009FE1 RID: 40929
		[Token(Token = "0x4009FE1")]
		[FieldOffset(Offset = "0xB0")]
		protected UILabel TeamName;

		// Token: 0x04009FE2 RID: 40930
		[Token(Token = "0x4009FE2")]
		[FieldOffset(Offset = "0xB8")]
		protected UILabel Name;

		// Token: 0x04009FE3 RID: 40931
		[Token(Token = "0x4009FE3")]
		[FieldOffset(Offset = "0xC0")]
		protected UISprite TeamBG;

		// Token: 0x04009FE4 RID: 40932
		[Token(Token = "0x4009FE4")]
		[FieldOffset(Offset = "0xC8")]
		protected UISprite NameBG;

		// Token: 0x04009FE5 RID: 40933
		[Token(Token = "0x4009FE5")]
		[FieldOffset(Offset = "0xD0")]
		protected UISprite HelmetBG;

		// Token: 0x04009FE6 RID: 40934
		[Token(Token = "0x4009FE6")]
		[FieldOffset(Offset = "0xD8")]
		protected UISprite FilledHelmet;

		// Token: 0x04009FE7 RID: 40935
		[Token(Token = "0x4009FE7")]
		[FieldOffset(Offset = "0xE0")]
		protected UISprite FilledHelmetEnhanced;

		// Token: 0x04009FE8 RID: 40936
		[Token(Token = "0x4009FE8")]
		[FieldOffset(Offset = "0xE8")]
		protected UISprite HelmetLevel;

		// Token: 0x04009FE9 RID: 40937
		[Token(Token = "0x4009FE9")]
		[FieldOffset(Offset = "0xF0")]
		protected UISprite ArmorBG;

		// Token: 0x04009FEA RID: 40938
		[Token(Token = "0x4009FEA")]
		[FieldOffset(Offset = "0xF8")]
		protected UISprite FilledArmor;

		// Token: 0x04009FEB RID: 40939
		[Token(Token = "0x4009FEB")]
		[FieldOffset(Offset = "0x100")]
		protected UISprite FilledArmorEnhanced;

		// Token: 0x04009FEC RID: 40940
		[Token(Token = "0x4009FEC")]
		[FieldOffset(Offset = "0x108")]
		protected UISprite ArmorLevel;

		// Token: 0x04009FED RID: 40941
		[Token(Token = "0x4009FED")]
		[FieldOffset(Offset = "0x110")]
		protected UILabel MedkitCount;

		// Token: 0x04009FEE RID: 40942
		[Token(Token = "0x4009FEE")]
		[FieldOffset(Offset = "0x118")]
		protected UILabel GrenadeCount;

		// Token: 0x04009FEF RID: 40943
		[Token(Token = "0x4009FEF")]
		[FieldOffset(Offset = "0x120")]
		protected UILabel SmokingBombCount;

		// Token: 0x04009FF0 RID: 40944
		[Token(Token = "0x4009FF0")]
		[FieldOffset(Offset = "0x128")]
		protected UILabel IceWallCount;

		// Token: 0x04009FF1 RID: 40945
		[Token(Token = "0x4009FF1")]
		[FieldOffset(Offset = "0x130")]
		protected UISprite icon;

		// Token: 0x04009FF2 RID: 40946
		[Token(Token = "0x4009FF2")]
		[FieldOffset(Offset = "0x138")]
		protected UILabel ItemCount;

		// Token: 0x04009FF3 RID: 40947
		[Token(Token = "0x4009FF3")]
		[FieldOffset(Offset = "0x140")]
		protected UILabel Kill;

		// Token: 0x04009FF4 RID: 40948
		[Token(Token = "0x4009FF4")]
		[FieldOffset(Offset = "0x148")]
		protected UILabel LabelKDA;

		// Token: 0x04009FF5 RID: 40949
		[Token(Token = "0x4009FF5")]
		[FieldOffset(Offset = "0x150")]
		protected UISprite WeaponIcon;

		// Token: 0x04009FF6 RID: 40950
		[Token(Token = "0x4009FF6")]
		[FieldOffset(Offset = "0x158")]
		protected Transform LeftAnchor;

		// Token: 0x04009FF7 RID: 40951
		[Token(Token = "0x4009FF7")]
		[FieldOffset(Offset = "0x160")]
		protected UIGrid Skills;

		// Token: 0x04009FF8 RID: 40952
		[Token(Token = "0x4009FF8")]
		[FieldOffset(Offset = "0x168")]
		protected UISPHudSkillItemView SkillTemplate;

		// Token: 0x04009FF9 RID: 40953
		[Token(Token = "0x4009FF9")]
		[FieldOffset(Offset = "0x170")]
		internal Player m_CurrentTrackingPlayer;

		// Token: 0x04009FFA RID: 40954
		[Token(Token = "0x4009FFA")]
		[FieldOffset(Offset = "0x178")]
		internal UIModelSpectator m_ModelSpectator;

		// Token: 0x04009FFB RID: 40955
		[Token(Token = "0x4009FFB")]
		[FieldOffset(Offset = "0x180")]
		private bool m_IsPlayerDieing;

		// Token: 0x04009FFC RID: 40956
		[Token(Token = "0x4009FFC")]
		[FieldOffset(Offset = "0x184")]
		private int curHelmetLevel;

		// Token: 0x04009FFD RID: 40957
		[Token(Token = "0x4009FFD")]
		[FieldOffset(Offset = "0x188")]
		private int curArmorLevel;

		// Token: 0x04009FFE RID: 40958
		[Token(Token = "0x4009FFE")]
		[FieldOffset(Offset = "0x190")]
		private string FilledArmorIcon;

		// Token: 0x04009FFF RID: 40959
		[Token(Token = "0x4009FFF")]
		[FieldOffset(Offset = "0x198")]
		private string FilledArmorIconBG;

		// Token: 0x0400A000 RID: 40960
		[Token(Token = "0x400A000")]
		[FieldOffset(Offset = "0x1A0")]
		private string FilledArmorIconExplode;

		// Token: 0x0400A001 RID: 40961
		[Token(Token = "0x400A001")]
		[FieldOffset(Offset = "0x1A8")]
		private string FilledArmorIconExplodeBG;

		// Token: 0x0400A002 RID: 40962
		[Token(Token = "0x400A002")]
		[FieldOffset(Offset = "0x1B0")]
		private string FilledHeadIcon;

		// Token: 0x0400A003 RID: 40963
		[Token(Token = "0x400A003")]
		[FieldOffset(Offset = "0x1B8")]
		private string FilledHeadIconBG;

		// Token: 0x0400A004 RID: 40964
		[Token(Token = "0x400A004")]
		[FieldOffset(Offset = "0x1C0")]
		private string FilledHeadIconProtect;

		// Token: 0x0400A005 RID: 40965
		[Token(Token = "0x400A005")]
		[FieldOffset(Offset = "0x1C8")]
		private string FilledHeadIconProtectBG;

		// Token: 0x0400A006 RID: 40966
		[Token(Token = "0x400A006")]
		[FieldOffset(Offset = "0x1D0")]
		private AHtazwI m_CurItemOnHand;

		// Token: 0x0400A007 RID: 40967
		[Token(Token = "0x400A007")]
		[FieldOffset(Offset = "0x1D8")]
		private W]MT\u0082aW m_CurItemTypeOnHand;

		// Token: 0x0400A008 RID: 40968
		[Token(Token = "0x400A008")]
		[FieldOffset(Offset = "0x1DC")]
		protected int weapon_origin_width;

		// Token: 0x0400A009 RID: 40969
		[Token(Token = "0x400A009")]
		[FieldOffset(Offset = "0x1E0")]
		protected int weapon_origin_height;

		// Token: 0x0400A00A RID: 40970
		[Token(Token = "0x400A00A")]
		[FieldOffset(Offset = "0x0")]
		protected static Color AmmoColorGolden;
	}
}
