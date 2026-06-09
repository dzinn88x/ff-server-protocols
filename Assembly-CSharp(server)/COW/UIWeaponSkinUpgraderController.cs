using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001BE0 RID: 7136
	[Token(Token = "0x2001BE0")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FB104", Offset = "0x10FB104")]
	public class UIWeaponSkinUpgraderController : UINavigationController, IUIModelDataChangeObserver
	{
		// Token: 0x06009AAC RID: 39596 RVA: 0x00028B30 File Offset: 0x00026D30
		[Token(Token = "0x6009AAC")]
		[Address(RVA = "0x221CF48", Offset = "0x221CF48", VA = "0x7BBCA1CF48")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06009AAD RID: 39597 RVA: 0x00028B48 File Offset: 0x00026D48
		[Token(Token = "0x6009AAD")]
		[Address(RVA = "0x221CF98", Offset = "0x221CF98", VA = "0x7BBCA1CF98", Slot = "33")]
		public override EFrontendUIType GetBackgroundImageType()
		{
			return EFrontendUIType.Lobby;
		}

		// Token: 0x06009AAE RID: 39598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009AAE")]
		[Address(RVA = "0x221CFA0", Offset = "0x221CFA0", VA = "0x7BBCA1CFA0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06009AAF RID: 39599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009AAF")]
		[Address(RVA = "0x221FA18", Offset = "0x221FA18", VA = "0x7BBCA1FA18", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x06009AB0 RID: 39600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009AB0")]
		[Address(RVA = "0x221FFF0", Offset = "0x221FFF0", VA = "0x7BBCA1FFF0")]
		public void OnPickLevel(object[] data)
		{
		}

		// Token: 0x06009AB1 RID: 39601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009AB1")]
		[Address(RVA = "0x22202E8", Offset = "0x22202E8", VA = "0x7BBCA202E8")]
		public void SetViewData(SkinOwnAndOpenInfo info, bool dismissShowOverview = false, bool needScollLevel = false)
		{
		}

		// Token: 0x06009AB2 RID: 39602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009AB2")]
		[Address(RVA = "0x2220628", Offset = "0x2220628", VA = "0x7BBCA20628")]
		private void OnUpgradePopupFinish(params object[] param)
		{
		}

		// Token: 0x06009AB3 RID: 39603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009AB3")]
		[Address(RVA = "0x2220A00", Offset = "0x2220A00", VA = "0x7BBCA20A00")]
		private void ShowPropertyAndSkillPanel(bool show)
		{
		}

		// Token: 0x06009AB4 RID: 39604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009AB4")]
		[Address(RVA = "0x2220BD8", Offset = "0x2220BD8", VA = "0x7BBCA20BD8")]
		private void ShowPropertyView(params object[] param)
		{
		}

		// Token: 0x06009AB5 RID: 39605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009AB5")]
		[Address(RVA = "0x2222140", Offset = "0x2222140", VA = "0x7BBCA22140")]
		private void PlayAnim()
		{
		}

		// Token: 0x06009AB6 RID: 39606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009AB6")]
		[Address(RVA = "0x222231C", Offset = "0x222231C", VA = "0x7BBCA2231C")]
		private void OnInterfaceMaskClick(params object[] data)
		{
		}

		// Token: 0x06009AB7 RID: 39607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009AB7")]
		[Address(RVA = "0x2222264", Offset = "0x2222264", VA = "0x7BBCA22264")]
		private void SetInterfaceMaskEnable(bool maskVisible, bool labelVisible)
		{
		}

		// Token: 0x06009AB8 RID: 39608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009AB8")]
		[Address(RVA = "0x22223DC", Offset = "0x22223DC", VA = "0x7BBCA223DC")]
		private void ProcessAnimEvt(params object[] data)
		{
		}

		// Token: 0x06009AB9 RID: 39609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009AB9")]
		[Address(RVA = "0x2222690", Offset = "0x2222690", VA = "0x7BBCA22690")]
		private void OnClickDetail()
		{
		}

		// Token: 0x06009ABA RID: 39610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009ABA")]
		[Address(RVA = "0x2221F60", Offset = "0x2221F60", VA = "0x7BBCA21F60")]
		private void ShowEfxAttrUp()
		{
		}

		// Token: 0x06009ABB RID: 39611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009ABB")]
		[Address(RVA = "0x2222068", Offset = "0x2222068", VA = "0x7BBCA22068")]
		private void ShowEfxSkill()
		{
		}

		// Token: 0x06009ABC RID: 39612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009ABC")]
		[Address(RVA = "0x2222720", Offset = "0x2222720", VA = "0x7BBCA22720")]
		private void OnClickDepot()
		{
		}

		// Token: 0x06009ABD RID: 39613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009ABD")]
		[Address(RVA = "0x2222778", Offset = "0x2222778", VA = "0x7BBCA22778")]
		private void OnClickOverviewPurchase()
		{
		}

		// Token: 0x06009ABE RID: 39614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009ABE")]
		[Address(RVA = "0x2222AFC", Offset = "0x2222AFC", VA = "0x7BBCA22AFC")]
		private void OnClickDetailPurchase()
		{
		}

		// Token: 0x06009ABF RID: 39615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009ABF")]
		[Address(RVA = "0x22228EC", Offset = "0x22228EC", VA = "0x7BBCA228EC")]
		private void OnClickPurchase()
		{
		}

		// Token: 0x06009AC0 RID: 39616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009AC0")]
		[Address(RVA = "0x2222C70", Offset = "0x2222C70", VA = "0x7BBCA22C70")]
		private void OnClickUpgrade()
		{
		}

		// Token: 0x06009AC1 RID: 39617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009AC1")]
		[Address(RVA = "0x2222E10", Offset = "0x2222E10", VA = "0x7BBCA22E10")]
		private void LogGetFragmentSuccess()
		{
		}

		// Token: 0x06009AC2 RID: 39618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009AC2")]
		[Address(RVA = "0x2223004", Offset = "0x2223004", VA = "0x7BBCA23004")]
		private void OnClickGetFragment()
		{
		}

		// Token: 0x06009AC3 RID: 39619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009AC3")]
		[Address(RVA = "0x2223B70", Offset = "0x2223B70", VA = "0x7BBCA23B70", Slot = "28")]
		public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
		{
		}

		// Token: 0x06009AC4 RID: 39620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009AC4")]
		[Address(RVA = "0x2223F10", Offset = "0x2223F10", VA = "0x7BBCA23F10", Slot = "29")]
		public override void OnNavigationClosed()
		{
		}

		// Token: 0x06009AC5 RID: 39621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009AC5")]
		[Address(RVA = "0x22240FC", Offset = "0x22240FC", VA = "0x7BBCA240FC", Slot = "39")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06009AC6 RID: 39622 RVA: 0x00028B60 File Offset: 0x00026D60
		[Token(Token = "0x6009AC6")]
		[Address(RVA = "0x22244A4", Offset = "0x22244A4", VA = "0x7BBCA244A4", Slot = "40")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06009AC7 RID: 39623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009AC7")]
		[Address(RVA = "0x221DFD4", Offset = "0x221DFD4", VA = "0x7BBCA1DFD4")]
		private void RefreshView(bool needScorllLevel = false)
		{
		}

		// Token: 0x06009AC8 RID: 39624 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009AC8")]
		[Address(RVA = "0x2225A48", Offset = "0x2225A48", VA = "0x7BBCA25A48")]
		private List<WeaponSkinFeature> RefreshPropertyContainer()
		{
			return null;
		}

		// Token: 0x06009AC9 RID: 39625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009AC9")]
		[Address(RVA = "0x2224F48", Offset = "0x2224F48", VA = "0x7BBCA24F48")]
		private void RefreshFeatureAddContainer()
		{
		}

		// Token: 0x06009ACA RID: 39626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009ACA")]
		[Address(RVA = "0x222534C", Offset = "0x222534C", VA = "0x7BBCA2534C")]
		private void RefreshLevelPickContainer(bool needScorllLevel)
		{
		}

		// Token: 0x06009ACB RID: 39627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009ACB")]
		[Address(RVA = "0x2226AFC", Offset = "0x2226AFC", VA = "0x7BBCA26AFC")]
		private void ScrollTo(Vector3 pos)
		{
		}

		// Token: 0x06009ACC RID: 39628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009ACC")]
		[Address(RVA = "0x2221830", Offset = "0x2221830", VA = "0x7BBCA21830")]
		private void Refresh3dWeapon(ResourceID model_id, bool isWeapon = true)
		{
		}

		// Token: 0x06009ACD RID: 39629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009ACD")]
		[Address(RVA = "0x2226D6C", Offset = "0x2226D6C", VA = "0x7BBCA26D6C")]
		private void AutoModifyPreviewModelAccordingToResolution(ref GameObject go, bool useY = false, float scaley = 0.5f, bool isAvatar = false)
		{
		}

		// Token: 0x06009ACE RID: 39630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009ACE")]
		[Address(RVA = "0x22275E0", Offset = "0x22275E0", VA = "0x7BBCA275E0")]
		private void AutoShift3DPreview(ref GameObject go, float scalex, float scaley, bool useY)
		{
		}

		// Token: 0x06009ACF RID: 39631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009ACF")]
		[Address(RVA = "0x2226F28", Offset = "0x2226F28", VA = "0x7BBCA26F28")]
		private void AutoGen3DPreviewCollider(GameObject go, bool isAvatar = false)
		{
		}

		// Token: 0x06009AD0 RID: 39632 RVA: 0x00028B78 File Offset: 0x00026D78
		[Token(Token = "0x6009AD0")]
		[Address(RVA = "0x2227BC4", Offset = "0x2227BC4", VA = "0x7BBCA27BC4")]
		private bool CheckInvaildCollider(Renderer render)
		{
			return default(bool);
		}

		// Token: 0x06009AD1 RID: 39633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009AD1")]
		[Address(RVA = "0x2227D64", Offset = "0x2227D64", VA = "0x7BBCA27D64")]
		protected void Ondraging(GameObject go, Vector2 delta)
		{
		}

		// Token: 0x06009AD2 RID: 39634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009AD2")]
		[Address(RVA = "0x2227EA8", Offset = "0x2227EA8", VA = "0x7BBCA27EA8")]
		private void OndragStart(GameObject gameObject)
		{
		}

		// Token: 0x06009AD3 RID: 39635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009AD3")]
		[Address(RVA = "0x2227EB0", Offset = "0x2227EB0", VA = "0x7BBCA27EB0")]
		private void OndragEnd(GameObject gameObject)
		{
		}

		// Token: 0x06009AD4 RID: 39636 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009AD4")]
		[Address(RVA = "0x2227EFC", Offset = "0x2227EFC", VA = "0x7BBCA27EFC")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x114509C", Offset = "0x114509C")]
		private IEnumerator ResetWeapon()
		{
			return null;
		}

		// Token: 0x06009AD5 RID: 39637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009AD5")]
		[Address(RVA = "0x221DD2C", Offset = "0x221DD2C", VA = "0x7BBCA1DD2C")]
		public void DisplayWeaponPropertyScore(bool show)
		{
		}

		// Token: 0x06009AD6 RID: 39638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009AD6")]
		[Address(RVA = "0x2224548", Offset = "0x2224548", VA = "0x7BBCA24548")]
		public void RefreshWeaponPropertyScore()
		{
		}

		// Token: 0x06009AD7 RID: 39639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009AD7")]
		[Address(RVA = "0x2227F9C", Offset = "0x2227F9C", VA = "0x7BBCA27F9C")]
		private void RefreshScoreGrid()
		{
		}

		// Token: 0x06009AD8 RID: 39640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009AD8")]
		[Address(RVA = "0x2220784", Offset = "0x2220784", VA = "0x7BBCA20784")]
		private void ShowPreviewItem(bool showPreviewItem, bool showUpgradeEfx)
		{
		}

		// Token: 0x06009AD9 RID: 39641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009AD9")]
		[Address(RVA = "0x2228020", Offset = "0x2228020", VA = "0x7BBCA28020")]
		public UIWeaponSkinUpgraderController()
		{
		}

		// Token: 0x06009ADA RID: 39642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009ADA")]
		[Address(RVA = "0x2228098", Offset = "0x2228098", VA = "0x7BBCA28098")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1145100", Offset = "0x1145100")]
		private void <OnClickUpgrade>b__43_0()
		{
		}

		// Token: 0x0400A15D RID: 41309
		[Token(Token = "0x400A15D")]
		[FieldOffset(Offset = "0xB0")]
		private UIWeaponSkinUpgraderView m_View;

		// Token: 0x0400A15E RID: 41310
		[Token(Token = "0x400A15E")]
		[FieldOffset(Offset = "0xB8")]
		private SkinOwnAndOpenInfo m_SkinOwnAndOpenInfo;

		// Token: 0x0400A15F RID: 41311
		[Token(Token = "0x400A15F")]
		[FieldOffset(Offset = "0xC0")]
		private bool m_IsOverview;

		// Token: 0x0400A160 RID: 41312
		[Token(Token = "0x400A160")]
		[FieldOffset(Offset = "0xC1")]
		private bool m_ShowAnim;

		// Token: 0x0400A161 RID: 41313
		[Token(Token = "0x400A161")]
		[FieldOffset(Offset = "0xC8")]
		private Transform m_FullScreenAnim;

		// Token: 0x0400A162 RID: 41314
		[Token(Token = "0x400A162")]
		[FieldOffset(Offset = "0xD0")]
		private UIModelWeaponSkinUpgrader m_ModelWeaponSkinUpgrader;

		// Token: 0x0400A163 RID: 41315
		[Token(Token = "0x400A163")]
		[FieldOffset(Offset = "0xD8")]
		private GameObject m_PreviewWeaponObj;

		// Token: 0x0400A164 RID: 41316
		[Token(Token = "0x400A164")]
		[FieldOffset(Offset = "0xE0")]
		private GameObject m_UpgradeEfx;

		// Token: 0x0400A165 RID: 41317
		[Token(Token = "0x400A165")]
		[FieldOffset(Offset = "0xE8")]
		private GameObject m_ItemCameraGo;

		// Token: 0x0400A166 RID: 41318
		[Token(Token = "0x400A166")]
		[FieldOffset(Offset = "0xF0")]
		private Camera m_ItemCamera;

		// Token: 0x0400A167 RID: 41319
		[Token(Token = "0x400A167")]
		[FieldOffset(Offset = "0xF8")]
		private WeaponSkinFeature m_CurrentFeature;

		// Token: 0x0400A168 RID: 41320
		[Token(Token = "0x400A168")]
		[FieldOffset(Offset = "0x100")]
		private GameObject m_JmpCgPanel;

		// Token: 0x0400A169 RID: 41321
		[Token(Token = "0x400A169")]
		[FieldOffset(Offset = "0x108")]
		private PreviewWsuJumpCgPanelController m_JmpCgPanelCtrl;

		// Token: 0x0400A16A RID: 41322
		[Token(Token = "0x400A16A")]
		[FieldOffset(Offset = "0x110")]
		private ResourceID m_ModelId;

		// Token: 0x0400A16B RID: 41323
		[Token(Token = "0x400A16B")]
		[FieldOffset(Offset = "0x118")]
		private UIWeaponSkillItemController m_skillItem;

		// Token: 0x0400A16C RID: 41324
		[Token(Token = "0x400A16C")]
		private const float m_RotateRate = 0.5f;

		// Token: 0x0400A16D RID: 41325
		[Token(Token = "0x400A16D")]
		[FieldOffset(Offset = "0x120")]
		private Coroutine m_RotateWeaponCoroutine;

		// Token: 0x0400A16E RID: 41326
		[Token(Token = "0x400A16E")]
		private const int m_MaxMaterialCount = 5000;

		// Token: 0x0400A16F RID: 41327
		[Token(Token = "0x400A16F")]
		[FieldOffset(Offset = "0x128")]
		private uint m_EnableBtnUpgradeCallId;

		// Token: 0x0400A170 RID: 41328
		[Token(Token = "0x400A170")]
		[FieldOffset(Offset = "0x12C")]
		private uint m_LevelGridReposCallId;

		// Token: 0x0400A171 RID: 41329
		[Token(Token = "0x400A171")]
		[FieldOffset(Offset = "0x130")]
		private GameObject m_UI3dCameraGo;

		// Token: 0x0400A172 RID: 41330
		[Token(Token = "0x400A172")]
		[FieldOffset(Offset = "0x138")]
		private UIWeaponKillNotificationItemController m_AnnouncementObj;

		// Token: 0x0400A173 RID: 41331
		[Token(Token = "0x400A173")]
		[FieldOffset(Offset = "0x140")]
		private bool m_HasRequest;

		// Token: 0x02001BE1 RID: 7137
		[Token(Token = "0x2001BE1")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FB13C", Offset = "0x10FB13C")]
		private sealed class <>c__DisplayClass48_0
		{
			// Token: 0x06009ADB RID: 39643 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009ADB")]
			[Address(RVA = "0x222449C", Offset = "0x222449C", VA = "0x7BBCA2449C")]
			public <>c__DisplayClass48_0()
			{
			}

			// Token: 0x06009ADC RID: 39644 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009ADC")]
			[Address(RVA = "0x22280DC", Offset = "0x22280DC", VA = "0x7BBCA280DC")]
			internal void <OnDataChanged>b__0()
			{
			}

			// Token: 0x0400A174 RID: 41332
			[Token(Token = "0x400A174")]
			[FieldOffset(Offset = "0x10")]
			public object[] param;

			// Token: 0x0400A175 RID: 41333
			[Token(Token = "0x400A175")]
			[FieldOffset(Offset = "0x18")]
			public UIWeaponSkinUpgraderController <>4__this;
		}

		// Token: 0x02001BE2 RID: 7138
		[Token(Token = "0x2001BE2")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FB14C", Offset = "0x10FB14C")]
		private sealed class <>c__DisplayClass53_0
		{
			// Token: 0x06009ADD RID: 39645 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009ADD")]
			[Address(RVA = "0x2226374", Offset = "0x2226374", VA = "0x7BBCA26374")]
			public <>c__DisplayClass53_0()
			{
			}

			// Token: 0x06009ADE RID: 39646 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009ADE")]
			[Address(RVA = "0x2228598", Offset = "0x2228598", VA = "0x7BBCA28598")]
			internal void <RefreshLevelPickContainer>b__0()
			{
			}

			// Token: 0x0400A176 RID: 41334
			[Token(Token = "0x400A176")]
			[FieldOffset(Offset = "0x10")]
			public bool needScorllLevel;

			// Token: 0x0400A177 RID: 41335
			[Token(Token = "0x400A177")]
			[FieldOffset(Offset = "0x14")]
			public int chosenId;

			// Token: 0x0400A178 RID: 41336
			[Token(Token = "0x400A178")]
			[FieldOffset(Offset = "0x18")]
			public UIWeaponSkinUpgraderController <>4__this;
		}

		// Token: 0x02001BE3 RID: 7139
		[Token(Token = "0x2001BE3")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FB15C", Offset = "0x10FB15C")]
		private sealed class <ResetWeapon>d__63 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06009ADF RID: 39647 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009ADF")]
			[Address(RVA = "0x2227F70", Offset = "0x2227F70", VA = "0x7BBCA27F70")]
			[DebuggerHidden]
			public <ResetWeapon>d__63(int <>1__state)
			{
			}

			// Token: 0x06009AE0 RID: 39648 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009AE0")]
			[Address(RVA = "0x2228768", Offset = "0x2228768", VA = "0x7BBCA28768", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06009AE1 RID: 39649 RVA: 0x00028B90 File Offset: 0x00026D90
			[Token(Token = "0x6009AE1")]
			[Address(RVA = "0x222876C", Offset = "0x222876C", VA = "0x7BBCA2876C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000A54 RID: 2644
			// (get) Token: 0x06009AE2 RID: 39650 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000A54")]
			private object Current
			{
				[Token(Token = "0x6009AE2")]
				[Address(RVA = "0x22289D0", Offset = "0x22289D0", VA = "0x7BBCA289D0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06009AE3 RID: 39651 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009AE3")]
			[Address(RVA = "0x22289D8", Offset = "0x22289D8", VA = "0x7BBCA289D8", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000A55 RID: 2645
			// (get) Token: 0x06009AE4 RID: 39652 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000A55")]
			private object Current
			{
				[Token(Token = "0x6009AE4")]
				[Address(RVA = "0x2228A40", Offset = "0x2228A40", VA = "0x7BBCA28A40", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0400A179 RID: 41337
			[Token(Token = "0x400A179")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x0400A17A RID: 41338
			[Token(Token = "0x400A17A")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x0400A17B RID: 41339
			[Token(Token = "0x400A17B")]
			[FieldOffset(Offset = "0x20")]
			public UIWeaponSkinUpgraderController <>4__this;

			// Token: 0x0400A17C RID: 41340
			[Token(Token = "0x400A17C")]
			[FieldOffset(Offset = "0x28")]
			private Quaternion <lerproate>5__2;

			// Token: 0x0400A17D RID: 41341
			[Token(Token = "0x400A17D")]
			[FieldOffset(Offset = "0x38")]
			private float <time>5__3;
		}
	}
}
