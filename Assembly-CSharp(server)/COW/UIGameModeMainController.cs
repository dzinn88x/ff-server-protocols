using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001849 RID: 6217
	[Token(Token = "0x2001849")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F3B8C", Offset = "0x10F3B8C")]
	internal class UIGameModeMainController : UIPopupWindowController, IUIModelDataChangeObserver
	{
		// Token: 0x060079E6 RID: 31206 RVA: 0x00021858 File Offset: 0x0001FA58
		[Token(Token = "0x60079E6")]
		[Address(RVA = "0x20050A0", Offset = "0x20050A0", VA = "0x7BBC8050A0")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060079E7 RID: 31207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079E7")]
		[Address(RVA = "0x20050F0", Offset = "0x20050F0", VA = "0x7BBC8050F0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060079E8 RID: 31208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079E8")]
		[Address(RVA = "0x2005960", Offset = "0x2005960", VA = "0x7BBC805960")]
		private void ShowRankGuide()
		{
		}

		// Token: 0x060079E9 RID: 31209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079E9")]
		[Address(RVA = "0x200560C", Offset = "0x200560C", VA = "0x7BBC80560C")]
		private void SetTrainingGuide()
		{
		}

		// Token: 0x060079EA RID: 31210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079EA")]
		[Address(RVA = "0x2005D6C", Offset = "0x2005D6C", VA = "0x7BBC805D6C")]
		public void CloseRankGuide()
		{
		}

		// Token: 0x060079EB RID: 31211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079EB")]
		[Address(RVA = "0x2005E08", Offset = "0x2005E08", VA = "0x7BBC805E08")]
		public void SetUIData()
		{
		}

		// Token: 0x060079EC RID: 31212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60079EC")]
		[Address(RVA = "0x200710C", Offset = "0x200710C", VA = "0x7BBC80710C")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x114226C", Offset = "0x114226C")]
		private IEnumerator RefreshScrollPos()
		{
			return null;
		}

		// Token: 0x060079ED RID: 31213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60079ED")]
		[Address(RVA = "0x2007180", Offset = "0x2007180", VA = "0x7BBC807180")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x11422D0", Offset = "0x11422D0")]
		private IEnumerator RefineItemPos()
		{
			return null;
		}

		// Token: 0x060079EE RID: 31214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079EE")]
		[Address(RVA = "0x200724C", Offset = "0x200724C", VA = "0x7BBC80724C", Slot = "19")]
		protected override void OnVisibilityChanged()
		{
		}

		// Token: 0x060079EF RID: 31215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079EF")]
		[Address(RVA = "0x200763C", Offset = "0x200763C", VA = "0x7BBC80763C", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060079F0 RID: 31216 RVA: 0x00021870 File Offset: 0x0001FA70
		[Token(Token = "0x60079F0")]
		[Address(RVA = "0x20077C8", Offset = "0x20077C8", VA = "0x7BBC8077C8")]
		private int customSort(Transform t1, Transform t2)
		{
			return 0;
		}

		// Token: 0x060079F1 RID: 31217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079F1")]
		[Address(RVA = "0x2007874", Offset = "0x2007874", VA = "0x7BBC807874")]
		private void OnCustomRoomClick()
		{
		}

		// Token: 0x060079F2 RID: 31218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079F2")]
		[Address(RVA = "0x2007C80", Offset = "0x2007C80", VA = "0x7BBC807C80")]
		private void OnTrainingClick()
		{
		}

		// Token: 0x060079F3 RID: 31219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079F3")]
		[Address(RVA = "0x2007C70", Offset = "0x2007C70", VA = "0x7BBC807C70")]
		private void OnLeaveBtnClick()
		{
		}

		// Token: 0x060079F4 RID: 31220 RVA: 0x00021888 File Offset: 0x0001FA88
		[Token(Token = "0x60079F4")]
		[Address(RVA = "0x2007FB0", Offset = "0x2007FB0", VA = "0x7BBC807FB0", Slot = "36")]
		public override bool ClosedByEsc()
		{
			return default(bool);
		}

		// Token: 0x060079F5 RID: 31221 RVA: 0x000218A0 File Offset: 0x0001FAA0
		[Token(Token = "0x60079F5")]
		[Address(RVA = "0x2007FD4", Offset = "0x2007FD4", VA = "0x7BBC807FD4", Slot = "37")]
		public override bool IgnoreEsc()
		{
			return default(bool);
		}

		// Token: 0x060079F6 RID: 31222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079F6")]
		[Address(RVA = "0x2008014", Offset = "0x2008014", VA = "0x7BBC808014")]
		private void OnServerConfirmed(params object[] data)
		{
		}

		// Token: 0x060079F7 RID: 31223 RVA: 0x000218B8 File Offset: 0x0001FAB8
		[Token(Token = "0x60079F7")]
		[Address(RVA = "0x20080D0", Offset = "0x20080D0", VA = "0x7BBC8080D0", Slot = "41")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x060079F8 RID: 31224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079F8")]
		[Address(RVA = "0x20080D8", Offset = "0x20080D8", VA = "0x7BBC8080D8", Slot = "40")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x060079F9 RID: 31225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60079F9")]
		public T OpenChild<T>(Transform parent, [Optional] Vector3 localPosition, EUIAnchor anchor = EUIAnchor.None) where T : UIBaseController
		{
			return null;
		}

		// Token: 0x060079FA RID: 31226 RVA: 0x000218D0 File Offset: 0x0001FAD0
		[Token(Token = "0x60079FA")]
		[Address(RVA = "0x1FFBE84", Offset = "0x1FFBE84", VA = "0x7BBC7FBE84")]
		public int GetScrollViewPanelDepth()
		{
			return 0;
		}

		// Token: 0x060079FB RID: 31227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079FB")]
		[Address(RVA = "0x2008134", Offset = "0x2008134", VA = "0x7BBC808134")]
		private void OnOpenRankMapSelector(params object[] data)
		{
		}

		// Token: 0x060079FC RID: 31228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079FC")]
		[Address(RVA = "0x200825C", Offset = "0x200825C", VA = "0x7BBC80825C")]
		public UIGameModeMainController()
		{
		}

		// Token: 0x04008EF3 RID: 36595
		[Token(Token = "0x4008EF3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private UIGameModeMainView m_View;

		// Token: 0x04008EF4 RID: 36596
		[Token(Token = "0x4008EF4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private UIModelMapOpeningInfo m_ModelMap;

		// Token: 0x04008EF5 RID: 36597
		[Token(Token = "0x4008EF5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private bool m_DataInit;

		// Token: 0x04008EF6 RID: 36598
		[Token(Token = "0x4008EF6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private float m_CellSpacing;

		// Token: 0x04008EF7 RID: 36599
		[Token(Token = "0x4008EF7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private float m_RankItemWidth;

		// Token: 0x04008EF8 RID: 36600
		[Token(Token = "0x4008EF8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private float m_ClassicItemWidth;

		// Token: 0x04008EF9 RID: 36601
		[Token(Token = "0x4008EF9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private float m_CSRankItemWidth;

		// Token: 0x04008EFA RID: 36602
		[Token(Token = "0x4008EFA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private float m_CasualItemWidth;

		// Token: 0x04008EFB RID: 36603
		[Token(Token = "0x4008EFB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private UICommonGuideController m_RankGuideCtrl;

		// Token: 0x04008EFC RID: 36604
		[Token(Token = "0x4008EFC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private UIWidget m_RankWidget;

		// Token: 0x04008EFD RID: 36605
		[Token(Token = "0x4008EFD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private UIModelUser m_ModelUser;

		// Token: 0x04008EFE RID: 36606
		[Token(Token = "0x4008EFE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private UIGameModeRankItemController m_RankItemController;

		// Token: 0x04008EFF RID: 36607
		[Token(Token = "0x4008EFF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private UIRankMapSelectController m_RankMapSelectController;

		// Token: 0x04008F00 RID: 36608
		[Token(Token = "0x4008F00")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private string TRAINING_GUIDE;

		// Token: 0x04008F01 RID: 36609
		[Token(Token = "0x4008F01")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Color TRAINING_LOCK_COL;

		// Token: 0x0200184A RID: 6218
		[Token(Token = "0x200184A")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F3BC4", Offset = "0x10F3BC4")]
		private sealed class <RefreshScrollPos>d__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x060079FD RID: 31229 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60079FD")]
			[Address(RVA = "0x20071F4", Offset = "0x20071F4", VA = "0x7BBC8071F4")]
			[DebuggerHidden]
			public <RefreshScrollPos>d__21(int <>1__state)
			{
			}

			// Token: 0x060079FE RID: 31230 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60079FE")]
			[Address(RVA = "0x2008C24", Offset = "0x2008C24", VA = "0x7BBC808C24", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x060079FF RID: 31231 RVA: 0x000218E8 File Offset: 0x0001FAE8
			[Token(Token = "0x60079FF")]
			[Address(RVA = "0x2008C28", Offset = "0x2008C28", VA = "0x7BBC808C28", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000974 RID: 2420
			// (get) Token: 0x06007A00 RID: 31232 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000974")]
			private object Current
			{
				[Token(Token = "0x6007A00")]
				[Address(RVA = "0x2008E24", Offset = "0x2008E24", VA = "0x7BBC808E24", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06007A01 RID: 31233 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A01")]
			[Address(RVA = "0x2008E2C", Offset = "0x2008E2C", VA = "0x7BBC808E2C", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000975 RID: 2421
			// (get) Token: 0x06007A02 RID: 31234 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000975")]
			private object Current
			{
				[Token(Token = "0x6007A02")]
				[Address(RVA = "0x2008E94", Offset = "0x2008E94", VA = "0x7BBC808E94", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04008F02 RID: 36610
			[Token(Token = "0x4008F02")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04008F03 RID: 36611
			[Token(Token = "0x4008F03")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04008F04 RID: 36612
			[Token(Token = "0x4008F04")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public UIGameModeMainController <>4__this;
		}

		// Token: 0x0200184B RID: 6219
		[Token(Token = "0x200184B")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F3BD4", Offset = "0x10F3BD4")]
		private sealed class <RefineItemPos>d__22 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06007A03 RID: 31235 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A03")]
			[Address(RVA = "0x2007220", Offset = "0x2007220", VA = "0x7BBC807220")]
			[DebuggerHidden]
			public <RefineItemPos>d__22(int <>1__state)
			{
			}

			// Token: 0x06007A04 RID: 31236 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A04")]
			[Address(RVA = "0x2008298", Offset = "0x2008298", VA = "0x7BBC808298", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06007A05 RID: 31237 RVA: 0x00021900 File Offset: 0x0001FB00
			[Token(Token = "0x6007A05")]
			[Address(RVA = "0x200829C", Offset = "0x200829C", VA = "0x7BBC80829C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000976 RID: 2422
			// (get) Token: 0x06007A06 RID: 31238 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000976")]
			private object Current
			{
				[Token(Token = "0x6007A06")]
				[Address(RVA = "0x2008BAC", Offset = "0x2008BAC", VA = "0x7BBC808BAC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06007A07 RID: 31239 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A07")]
			[Address(RVA = "0x2008BB4", Offset = "0x2008BB4", VA = "0x7BBC808BB4", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000977 RID: 2423
			// (get) Token: 0x06007A08 RID: 31240 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000977")]
			private object Current
			{
				[Token(Token = "0x6007A08")]
				[Address(RVA = "0x2008C1C", Offset = "0x2008C1C", VA = "0x7BBC808C1C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04008F05 RID: 36613
			[Token(Token = "0x4008F05")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04008F06 RID: 36614
			[Token(Token = "0x4008F06")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04008F07 RID: 36615
			[Token(Token = "0x4008F07")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public UIGameModeMainController <>4__this;
		}
	}
}
