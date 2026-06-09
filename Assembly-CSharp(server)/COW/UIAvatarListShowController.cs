using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020016B3 RID: 5811
	[Token(Token = "0x20016B3")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F0A34", Offset = "0x10F0A34")]
	public class UIAvatarListShowController : UIBaseController, IEasyList
	{
		// Token: 0x06006A16 RID: 27158 RVA: 0x0001E0D8 File Offset: 0x0001C2D8
		[Token(Token = "0x6006A16")]
		[Address(RVA = "0x2075548", Offset = "0x2075548", VA = "0x7BBC875548")]
		public bool GetCanTouch()
		{
			return default(bool);
		}

		// Token: 0x06006A17 RID: 27159 RVA: 0x0001E0F0 File Offset: 0x0001C2F0
		[Token(Token = "0x6006A17")]
		[Address(RVA = "0x2075550", Offset = "0x2075550", VA = "0x7BBC875550")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006A18 RID: 27160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A18")]
		[Address(RVA = "0x20755A0", Offset = "0x20755A0", VA = "0x7BBC8755A0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006A19 RID: 27161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A19")]
		[Address(RVA = "0x2075E5C", Offset = "0x2075E5C", VA = "0x7BBC875E5C")]
		private void OnAwakenEntranceBtnClick()
		{
		}

		// Token: 0x06006A1A RID: 27162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A1A")]
		[Address(RVA = "0x2076104", Offset = "0x2076104", VA = "0x7BBC876104")]
		private void OnExchangeToAwakenAvatar()
		{
		}

		// Token: 0x06006A1B RID: 27163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A1B")]
		[Address(RVA = "0x2076568", Offset = "0x2076568", VA = "0x7BBC876568")]
		private void OnExchangeToOriAvatar()
		{
		}

		// Token: 0x06006A1C RID: 27164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A1C")]
		[Address(RVA = "0x2076950", Offset = "0x2076950", VA = "0x7BBC876950")]
		private void OnUpdateAwakenData(params object[] param)
		{
		}

		// Token: 0x06006A1D RID: 27165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A1D")]
		[Address(RVA = "0x2076A8C", Offset = "0x2076A8C", VA = "0x7BBC876A8C")]
		private void RefreshOnlyAvatar(uint avarid)
		{
		}

		// Token: 0x06006A1E RID: 27166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A1E")]
		[Address(RVA = "0x2076ECC", Offset = "0x2076ECC", VA = "0x7BBC876ECC")]
		private void StartSuitPreview(uint avatarId, uint[] clothsIds)
		{
		}

		// Token: 0x06006A1F RID: 27167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A1F")]
		[Address(RVA = "0x20770FC", Offset = "0x20770FC", VA = "0x7BBC8770FC")]
		private void OnTweenAnimationFinish()
		{
		}

		// Token: 0x06006A20 RID: 27168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A20")]
		[Address(RVA = "0x2077770", Offset = "0x2077770", VA = "0x7BBC877770")]
		public void OnBtnCloseClick()
		{
		}

		// Token: 0x06006A21 RID: 27169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A21")]
		[Address(RVA = "0x2077AC0", Offset = "0x2077AC0", VA = "0x7BBC877AC0")]
		public void InitAvatarTween()
		{
		}

		// Token: 0x06006A22 RID: 27170 RVA: 0x0001E108 File Offset: 0x0001C308
		[Token(Token = "0x6006A22")]
		[Address(RVA = "0x2077EC0", Offset = "0x2077EC0", VA = "0x7BBC877EC0")]
		private bool CheckHasTips(AvatarProfile profile)
		{
			return default(bool);
		}

		// Token: 0x06006A23 RID: 27171 RVA: 0x0001E120 File Offset: 0x0001C320
		[Token(Token = "0x6006A23")]
		[Address(RVA = "0x2077F34", Offset = "0x2077F34", VA = "0x7BBC877F34")]
		private bool CheckHasAwakenTips(AvatarProfile profile)
		{
			return default(bool);
		}

		// Token: 0x06006A24 RID: 27172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A24")]
		[Address(RVA = "0x207802C", Offset = "0x207802C", VA = "0x7BBC87802C")]
		private void RefreshRedTips()
		{
		}

		// Token: 0x06006A25 RID: 27173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A25")]
		[Address(RVA = "0x207822C", Offset = "0x207822C", VA = "0x7BBC87822C")]
		private void OnUpdateRedTips(params object[] data)
		{
		}

		// Token: 0x06006A26 RID: 27174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A26")]
		[Address(RVA = "0x2078230", Offset = "0x2078230", VA = "0x7BBC878230")]
		private void OnUpdateAvatarAWAKEN(params object[] data)
		{
		}

		// Token: 0x06006A27 RID: 27175 RVA: 0x0001E138 File Offset: 0x0001C338
		[Token(Token = "0x6006A27")]
		[Address(RVA = "0x2078874", Offset = "0x2078874", VA = "0x7BBC878874")]
		private int GetStrIndex(string str)
		{
			return 0;
		}

		// Token: 0x06006A28 RID: 27176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A28")]
		[Address(RVA = "0x2078940", Offset = "0x2078940", VA = "0x7BBC878940")]
		private void GeneratePopList()
		{
		}

		// Token: 0x06006A29 RID: 27177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A29")]
		[Address(RVA = "0x2077C94", Offset = "0x2077C94", VA = "0x7BBC877C94")]
		public void UpdateSelectState(int index)
		{
		}

		// Token: 0x06006A2A RID: 27178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A2A")]
		[Address(RVA = "0x2078BEC", Offset = "0x2078BEC", VA = "0x7BBC878BEC")]
		private string GetSpriteNameByStr(string str)
		{
			return null;
		}

		// Token: 0x06006A2B RID: 27179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A2B")]
		[Address(RVA = "0x2078DDC", Offset = "0x2078DDC", VA = "0x7BBC878DDC")]
		private void OnSelectCallback(object obj)
		{
		}

		// Token: 0x06006A2C RID: 27180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A2C")]
		[Address(RVA = "0x2079190", Offset = "0x2079190", VA = "0x7BBC879190", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06006A2D RID: 27181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A2D")]
		[Address(RVA = "0x2079410", Offset = "0x2079410", VA = "0x7BBC879410", Slot = "28")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x06006A2E RID: 27182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A2E")]
		[Address(RVA = "0x20794A4", Offset = "0x20794A4", VA = "0x7BBC8794A4", Slot = "29")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x06006A2F RID: 27183 RVA: 0x0001E150 File Offset: 0x0001C350
		[Token(Token = "0x6006A2F")]
		[Address(RVA = "0x20794D4", Offset = "0x20794D4", VA = "0x7BBC8794D4")]
		private int GetPositiveVal(AvatarListItemData a)
		{
			return 0;
		}

		// Token: 0x06006A30 RID: 27184 RVA: 0x0001E168 File Offset: 0x0001C368
		[Token(Token = "0x6006A30")]
		[Address(RVA = "0x2079530", Offset = "0x2079530", VA = "0x7BBC879530")]
		private int GetSpecialPositiveVal(AvatarListItemData a)
		{
			return 0;
		}

		// Token: 0x06006A31 RID: 27185 RVA: 0x0001E180 File Offset: 0x0001C380
		[Token(Token = "0x6006A31")]
		[Address(RVA = "0x207958C", Offset = "0x207958C", VA = "0x7BBC87958C")]
		private int GetNegaVal(AvatarListItemData a)
		{
			return 0;
		}

		// Token: 0x06006A32 RID: 27186 RVA: 0x0001E198 File Offset: 0x0001C398
		[Token(Token = "0x6006A32")]
		[Address(RVA = "0x20795DC", Offset = "0x20795DC", VA = "0x7BBC8795DC")]
		private int GetAwakenVal(AvatarListItemData a)
		{
			return 0;
		}

		// Token: 0x06006A33 RID: 27187 RVA: 0x0001E1B0 File Offset: 0x0001C3B0
		[Token(Token = "0x6006A33")]
		[Address(RVA = "0x20779F4", Offset = "0x20779F4", VA = "0x7BBC8779F4")]
		private int CalcAvatarIndex()
		{
			return 0;
		}

		// Token: 0x06006A34 RID: 27188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A34")]
		[Address(RVA = "0x2078F48", Offset = "0x2078F48", VA = "0x7BBC878F48")]
		private void SortAvatarItem(UIAvatarListShowController.AvatarSortType type, bool forcerefresh = false)
		{
		}

		// Token: 0x06006A35 RID: 27189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A35")]
		[Address(RVA = "0x207975C", Offset = "0x207975C", VA = "0x7BBC87975C")]
		public void RefreshEasyListView()
		{
		}

		// Token: 0x06006A36 RID: 27190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A36")]
		[Address(RVA = "0x20798FC", Offset = "0x20798FC", VA = "0x7BBC8798FC")]
		public List<AvatarProfile> GetCurrentAvatarProflieList()
		{
			return null;
		}

		// Token: 0x06006A37 RID: 27191 RVA: 0x0001E1C8 File Offset: 0x0001C3C8
		[Token(Token = "0x6006A37")]
		[Address(RVA = "0x207602C", Offset = "0x207602C", VA = "0x7BBC87602C")]
		public uint GetCurrentShowAvatarId()
		{
			return 0U;
		}

		// Token: 0x06006A38 RID: 27192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A38")]
		[Address(RVA = "0x207990C", Offset = "0x207990C", VA = "0x7BBC87990C")]
		public void RefreshAllUI()
		{
		}

		// Token: 0x06006A39 RID: 27193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A39")]
		[Address(RVA = "0x20785F4", Offset = "0x20785F4", VA = "0x7BBC8785F4")]
		private void RefreshAwakenData(bool flag = true)
		{
		}

		// Token: 0x06006A3A RID: 27194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A3A")]
		[Address(RVA = "0x2079E8C", Offset = "0x2079E8C", VA = "0x7BBC879E8C")]
		public void SetCurrentAwakenSelect(uint avatarID, bool flag = true)
		{
		}

		// Token: 0x06006A3B RID: 27195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A3B")]
		[Address(RVA = "0x2077430", Offset = "0x2077430", VA = "0x7BBC877430")]
		private void RefreshData()
		{
		}

		// Token: 0x06006A3C RID: 27196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A3C")]
		[Address(RVA = "0x207A1E4", Offset = "0x207A1E4", VA = "0x7BBC87A1E4")]
		public UIAvatarListShowController()
		{
		}

		// Token: 0x06006A3E RID: 27198 RVA: 0x0001E1E0 File Offset: 0x0001C3E0
		[Token(Token = "0x6006A3E")]
		[Address(RVA = "0x207A3D0", Offset = "0x207A3D0", VA = "0x7BBC87A3D0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1140DA4", Offset = "0x1140DA4")]
		private int <SortAvatarItem>b__46_0(AvatarListItemData a, AvatarListItemData b)
		{
			return 0;
		}

		// Token: 0x06006A3F RID: 27199 RVA: 0x0001E1F8 File Offset: 0x0001C3F8
		[Token(Token = "0x6006A3F")]
		[Address(RVA = "0x207A400", Offset = "0x207A400", VA = "0x7BBC87A400")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1140DB4", Offset = "0x1140DB4")]
		private int <SortAvatarItem>b__46_1(AvatarListItemData a, AvatarListItemData b)
		{
			return 0;
		}

		// Token: 0x06006A40 RID: 27200 RVA: 0x0001E210 File Offset: 0x0001C410
		[Token(Token = "0x6006A40")]
		[Address(RVA = "0x207A430", Offset = "0x207A430", VA = "0x7BBC87A430")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1140DC4", Offset = "0x1140DC4")]
		private int <RefreshEasyListView>b__47_0(AvatarListItemData a, AvatarListItemData b)
		{
			return 0;
		}

		// Token: 0x06006A41 RID: 27201 RVA: 0x0001E228 File Offset: 0x0001C428
		[Token(Token = "0x6006A41")]
		[Address(RVA = "0x207A460", Offset = "0x207A460", VA = "0x7BBC87A460")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1140DD4", Offset = "0x1140DD4")]
		private int <RefreshEasyListView>b__47_1(AvatarListItemData a, AvatarListItemData b)
		{
			return 0;
		}

		// Token: 0x040086B6 RID: 34486
		[Token(Token = "0x40086B6")]
		[FieldOffset(Offset = "0x58")]
		private UIAvatarListShowView m_View;

		// Token: 0x040086B7 RID: 34487
		[Token(Token = "0x40086B7")]
		[FieldOffset(Offset = "0x60")]
		private List<AvatarProfile> m_AvatarProfileList;

		// Token: 0x040086B8 RID: 34488
		[Token(Token = "0x40086B8")]
		[FieldOffset(Offset = "0x68")]
		private List<AvatarListItemData> m_AvatarlistItems;

		// Token: 0x040086B9 RID: 34489
		[Token(Token = "0x40086B9")]
		[FieldOffset(Offset = "0x70")]
		private int m_MaxLevel;

		// Token: 0x040086BA RID: 34490
		[Token(Token = "0x40086BA")]
		[FieldOffset(Offset = "0x78")]
		private UIPopMenuSmallControler m_CurrentPop;

		// Token: 0x040086BB RID: 34491
		[Token(Token = "0x40086BB")]
		[FieldOffset(Offset = "0x80")]
		private List<PopMenuData> m_PopMenuList;

		// Token: 0x040086BC RID: 34492
		[Token(Token = "0x40086BC")]
		[FieldOffset(Offset = "0x88")]
		private List<string> m_PopStrList;

		// Token: 0x040086BD RID: 34493
		[Token(Token = "0x40086BD")]
		[FieldOffset(Offset = "0x90")]
		private string m_CurrentChooseTab;

		// Token: 0x040086BE RID: 34494
		[Token(Token = "0x40086BE")]
		[FieldOffset(Offset = "0x98")]
		private bool m_IsShrink;

		// Token: 0x040086BF RID: 34495
		[Token(Token = "0x40086BF")]
		[FieldOffset(Offset = "0x99")]
		private bool m_CanTouch;

		// Token: 0x040086C0 RID: 34496
		[Token(Token = "0x40086C0")]
		[FieldOffset(Offset = "0x0")]
		private static List<string> m_PopSpriteNames;

		// Token: 0x040086C1 RID: 34497
		[Token(Token = "0x40086C1")]
		[FieldOffset(Offset = "0xA0")]
		private EventDelegate m_Delegate;

		// Token: 0x040086C2 RID: 34498
		[Token(Token = "0x40086C2")]
		[FieldOffset(Offset = "0xA8")]
		private uint m_DelayCall;

		// Token: 0x040086C3 RID: 34499
		[Token(Token = "0x40086C3")]
		[FieldOffset(Offset = "0xAC")]
		private bool m_FirstEntered;

		// Token: 0x040086C4 RID: 34500
		[Token(Token = "0x40086C4")]
		[FieldOffset(Offset = "0xB0")]
		private UIAvatarListShowController.AvatarSortType m_Type;

		// Token: 0x020016B4 RID: 5812
		[Token(Token = "0x20016B4")]
		private enum AvatarSortType
		{
			// Token: 0x040086C6 RID: 34502
			[Token(Token = "0x40086C6")]
			PositiveLevel,
			// Token: 0x040086C7 RID: 34503
			[Token(Token = "0x40086C7")]
			Awakeken
		}

		// Token: 0x020016B5 RID: 5813
		[Token(Token = "0x20016B5")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F0A6C", Offset = "0x10F0A6C")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06006A43 RID: 27203 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A43")]
			[Address(RVA = "0x207A4F4", Offset = "0x207A4F4", VA = "0x7BBC87A4F4")]
			public <>c()
			{
			}

			// Token: 0x06006A44 RID: 27204 RVA: 0x0001E240 File Offset: 0x0001C440
			[Token(Token = "0x6006A44")]
			[Address(RVA = "0x207A4FC", Offset = "0x207A4FC", VA = "0x7BBC87A4FC")]
			internal bool <RefreshOnlyAvatar>b__23_0(AvatarSuit x)
			{
				return default(bool);
			}

			// Token: 0x06006A45 RID: 27205 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A45")]
			[Address(RVA = "0x207A528", Offset = "0x207A528", VA = "0x7BBC87A528")]
			internal void <OnTweenAnimationFinish>b__25_0()
			{
			}

			// Token: 0x040086C8 RID: 34504
			[Token(Token = "0x40086C8")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIAvatarListShowController.<>c <>9;

			// Token: 0x040086C9 RID: 34505
			[Token(Token = "0x40086C9")]
			[FieldOffset(Offset = "0x8")]
			public static Predicate<AvatarSuit> <>9__23_0;

			// Token: 0x040086CA RID: 34506
			[Token(Token = "0x40086CA")]
			[FieldOffset(Offset = "0x10")]
			public static Action <>9__25_0;
		}

		// Token: 0x020016B6 RID: 5814
		[Token(Token = "0x20016B6")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F0A7C", Offset = "0x10F0A7C")]
		private sealed class <>c__DisplayClass50_0
		{
			// Token: 0x06006A46 RID: 27206 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A46")]
			[Address(RVA = "0x2079E84", Offset = "0x2079E84", VA = "0x7BBC879E84")]
			public <>c__DisplayClass50_0()
			{
			}

			// Token: 0x06006A47 RID: 27207 RVA: 0x0001E258 File Offset: 0x0001C458
			[Token(Token = "0x6006A47")]
			[Address(RVA = "0x207A52C", Offset = "0x207A52C", VA = "0x7BBC87A52C")]
			internal bool <RefreshAllUI>b__0(AvatarProfile a)
			{
				return default(bool);
			}

			// Token: 0x040086CB RID: 34507
			[Token(Token = "0x40086CB")]
			[FieldOffset(Offset = "0x10")]
			public UIModelAvatarProfile model;
		}
	}
}
