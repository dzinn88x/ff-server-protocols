using System;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x02001A2C RID: 6700
	[Token(Token = "0x2001A2C")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F7AB4", Offset = "0x10F7AB4")]
	public class UILuckyBagController : UIPopupWindowController, IUIModelDataChangeObserver, IEasyList
	{
		// Token: 0x06008C8B RID: 35979 RVA: 0x000257E8 File Offset: 0x000239E8
		[Token(Token = "0x6008C8B")]
		[Address(RVA = "0x19EA008", Offset = "0x19EA008", VA = "0x7BBC1EA008")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008C8C RID: 35980 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6008C8C")]
		[Address(RVA = "0x19EA058", Offset = "0x19EA058", VA = "0x7BBC1EA058", Slot = "28")]
		public override string Rule()
		{
			return null;
		}

		// Token: 0x06008C8D RID: 35981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C8D")]
		[Address(RVA = "0x19EA0A0", Offset = "0x19EA0A0", VA = "0x7BBC1EA0A0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008C8E RID: 35982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C8E")]
		[Address(RVA = "0x19EA318", Offset = "0x19EA318", VA = "0x7BBC1EA318")]
		private void RefreshViewData()
		{
		}

		// Token: 0x06008C8F RID: 35983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C8F")]
		[Address(RVA = "0x19EA46C", Offset = "0x19EA46C", VA = "0x7BBC1EA46C")]
		private void HighlightCurrent()
		{
		}

		// Token: 0x06008C90 RID: 35984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C90")]
		[Address(RVA = "0x19EA628", Offset = "0x19EA628", VA = "0x7BBC1EA628")]
		private void OnLuckyBagDrawed(params object[] data)
		{
		}

		// Token: 0x06008C91 RID: 35985 RVA: 0x00025800 File Offset: 0x00023A00
		[Token(Token = "0x6008C91")]
		[Address(RVA = "0x19EA6B0", Offset = "0x19EA6B0", VA = "0x7BBC1EA6B0", Slot = "41")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06008C92 RID: 35986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C92")]
		[Address(RVA = "0x19EA6B8", Offset = "0x19EA6B8", VA = "0x7BBC1EA6B8", Slot = "40")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06008C93 RID: 35987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C93")]
		[Address(RVA = "0x19EA908", Offset = "0x19EA908", VA = "0x7BBC1EA908")]
		private void OnRefreshBtnClick()
		{
		}

		// Token: 0x06008C94 RID: 35988 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6008C94")]
		[Address(RVA = "0x19EA96C", Offset = "0x19EA96C", VA = "0x7BBC1EA96C", Slot = "42")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x06008C95 RID: 35989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C95")]
		[Address(RVA = "0x19EAA00", Offset = "0x19EAA00", VA = "0x7BBC1EAA00", Slot = "43")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x06008C96 RID: 35990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C96")]
		[Address(RVA = "0x19EAA30", Offset = "0x19EAA30", VA = "0x7BBC1EAA30", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06008C97 RID: 35991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C97")]
		[Address(RVA = "0x19EAB68", Offset = "0x19EAB68", VA = "0x7BBC1EAB68", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x06008C98 RID: 35992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C98")]
		[Address(RVA = "0x19EAB70", Offset = "0x19EAB70", VA = "0x7BBC1EAB70")]
		public UILuckyBagController()
		{
		}

		// Token: 0x06008C99 RID: 35993 RVA: 0x00025818 File Offset: 0x00023A18
		[Token(Token = "0x6008C99")]
		[Address(RVA = "0x19EAB78", Offset = "0x19EAB78", VA = "0x7BBC1EAB78")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1144368", Offset = "0x1144368")]
		private bool <HighlightCurrent>b__8_0(ClanLuckyBag item)
		{
			return default(bool);
		}

		// Token: 0x040098FE RID: 39166
		[Token(Token = "0x40098FE")]
		[FieldOffset(Offset = "0x98")]
		private UILuckyBagView m_View;

		// Token: 0x040098FF RID: 39167
		[Token(Token = "0x40098FF")]
		[FieldOffset(Offset = "0xA0")]
		private ClanLuckyBagConfigData m_ClanLuckyBagConfigData;

		// Token: 0x04009900 RID: 39168
		[Token(Token = "0x4009900")]
		[FieldOffset(Offset = "0xA8")]
		private UIModelClan m_ModelClan;

		// Token: 0x04009901 RID: 39169
		[Token(Token = "0x4009901")]
		[FieldOffset(Offset = "0xB0")]
		private ulong m_SelectedBagID;
	}
}
