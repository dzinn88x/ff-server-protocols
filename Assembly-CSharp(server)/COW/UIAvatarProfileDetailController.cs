using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020016BF RID: 5823
	[Token(Token = "0x20016BF")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F0B0C", Offset = "0x10F0B0C")]
	public class UIAvatarProfileDetailController : UIBaseController, IEasyList, IUIModelDataChangeObserver
	{
		// Token: 0x06006AA5 RID: 27301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AA5")]
		[Address(RVA = "0x2089110", Offset = "0x2089110", VA = "0x7BBC889110", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006AA6 RID: 27302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AA6")]
		[Address(RVA = "0x208946C", Offset = "0x208946C", VA = "0x7BBC88946C", Slot = "19")]
		protected override void OnVisibilityChanged()
		{
		}

		// Token: 0x06006AA7 RID: 27303 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006AA7")]
		[Address(RVA = "0x20894C8", Offset = "0x20894C8", VA = "0x7BBC8894C8")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1140E24", Offset = "0x1140E24")]
		private IEnumerator CoReShowLevelCardPanel()
		{
			return null;
		}

		// Token: 0x06006AA8 RID: 27304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AA8")]
		[Address(RVA = "0x2089568", Offset = "0x2089568", VA = "0x7BBC889568", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x06006AA9 RID: 27305 RVA: 0x0001E3A8 File Offset: 0x0001C5A8
		[Token(Token = "0x6006AA9")]
		[Address(RVA = "0x2089778", Offset = "0x2089778", VA = "0x7BBC889778")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006AAA RID: 27306 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006AAA")]
		[Address(RVA = "0x20897C8", Offset = "0x20897C8", VA = "0x7BBC8897C8")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1140E88", Offset = "0x1140E88")]
		private IEnumerator CoInitEasyList()
		{
			return null;
		}

		// Token: 0x06006AAB RID: 27307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AAB")]
		[Address(RVA = "0x2089868", Offset = "0x2089868", VA = "0x7BBC889868")]
		public void SetData(uint avatarID, uint level)
		{
		}

		// Token: 0x06006AAC RID: 27308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AAC")]
		[Address(RVA = "0x2089D60", Offset = "0x2089D60", VA = "0x7BBC889D60")]
		private void OnTipBtnClick()
		{
		}

		// Token: 0x06006AAD RID: 27309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AAD")]
		[Address(RVA = "0x2089F2C", Offset = "0x2089F2C", VA = "0x7BBC889F2C")]
		private void OnUpgradeCardClick()
		{
		}

		// Token: 0x06006AAE RID: 27310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AAE")]
		[Address(RVA = "0x208A098", Offset = "0x208A098", VA = "0x7BBC88A098")]
		private void OnBackProfile(params object[] data)
		{
		}

		// Token: 0x06006AAF RID: 27311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AAF")]
		[Address(RVA = "0x208A12C", Offset = "0x208A12C", VA = "0x7BBC88A12C")]
		private void OnAvatarProfileLevelUp(params object[] data)
		{
		}

		// Token: 0x06006AB0 RID: 27312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006AB0")]
		[Address(RVA = "0x208AACC", Offset = "0x208AACC", VA = "0x7BBC88AACC", Slot = "28")]
		private UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x06006AB1 RID: 27313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AB1")]
		[Address(RVA = "0x208AB60", Offset = "0x208AB60", VA = "0x7BBC88AB60", Slot = "29")]
		private void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x06006AB2 RID: 27314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AB2")]
		[Address(RVA = "0x208AB90", Offset = "0x208AB90", VA = "0x7BBC88AB90", Slot = "30")]
		private void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06006AB3 RID: 27315 RVA: 0x0001E3C0 File Offset: 0x0001C5C0
		[Token(Token = "0x6006AB3")]
		[Address(RVA = "0x208ACE8", Offset = "0x208ACE8", VA = "0x7BBC88ACE8", Slot = "31")]
		private uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06006AB4 RID: 27316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AB4")]
		[Address(RVA = "0x208AD4C", Offset = "0x208AD4C", VA = "0x7BBC88AD4C")]
		public UIAvatarProfileDetailController()
		{
		}

		// Token: 0x040086F4 RID: 34548
		[Token(Token = "0x40086F4")]
		[FieldOffset(Offset = "0x58")]
		private UIAvatarProfileDetailView m_View;

		// Token: 0x040086F5 RID: 34549
		[Token(Token = "0x40086F5")]
		[FieldOffset(Offset = "0x60")]
		private uint m_AvatarID;

		// Token: 0x040086F6 RID: 34550
		[Token(Token = "0x40086F6")]
		[FieldOffset(Offset = "0x64")]
		private uint m_ToLevel;

		// Token: 0x040086F7 RID: 34551
		[Token(Token = "0x40086F7")]
		[FieldOffset(Offset = "0x68")]
		private UIUseUpgradeCardController m_UpgradeCardController;

		// Token: 0x040086F8 RID: 34552
		[Token(Token = "0x40086F8")]
		[FieldOffset(Offset = "0x70")]
		private bool needShowLevelCardPanel;

		// Token: 0x040086F9 RID: 34553
		[Token(Token = "0x40086F9")]
		[FieldOffset(Offset = "0x74")]
		private int defaultSelectedIndex;

		// Token: 0x020016C0 RID: 5824
		[Token(Token = "0x20016C0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F0B44", Offset = "0x10F0B44")]
		private sealed class <CoReShowLevelCardPanel>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06006AB5 RID: 27317 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006AB5")]
			[Address(RVA = "0x208953C", Offset = "0x208953C", VA = "0x7BBC88953C")]
			[DebuggerHidden]
			public <CoReShowLevelCardPanel>d__8(int <>1__state)
			{
			}

			// Token: 0x06006AB6 RID: 27318 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006AB6")]
			[Address(RVA = "0x208AE78", Offset = "0x208AE78", VA = "0x7BBC88AE78", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06006AB7 RID: 27319 RVA: 0x0001E3D8 File Offset: 0x0001C5D8
			[Token(Token = "0x6006AB7")]
			[Address(RVA = "0x208AE7C", Offset = "0x208AE7C", VA = "0x7BBC88AE7C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x1700091B RID: 2331
			// (get) Token: 0x06006AB8 RID: 27320 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700091B")]
			private object Current
			{
				[Token(Token = "0x6006AB8")]
				[Address(RVA = "0x208AF14", Offset = "0x208AF14", VA = "0x7BBC88AF14", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06006AB9 RID: 27321 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006AB9")]
			[Address(RVA = "0x208AF1C", Offset = "0x208AF1C", VA = "0x7BBC88AF1C", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x1700091C RID: 2332
			// (get) Token: 0x06006ABA RID: 27322 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700091C")]
			private object Current
			{
				[Token(Token = "0x6006ABA")]
				[Address(RVA = "0x208AF84", Offset = "0x208AF84", VA = "0x7BBC88AF84", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x040086FA RID: 34554
			[Token(Token = "0x40086FA")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x040086FB RID: 34555
			[Token(Token = "0x40086FB")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x040086FC RID: 34556
			[Token(Token = "0x40086FC")]
			[FieldOffset(Offset = "0x20")]
			public UIAvatarProfileDetailController <>4__this;
		}

		// Token: 0x020016C1 RID: 5825
		[Token(Token = "0x20016C1")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F0B54", Offset = "0x10F0B54")]
		private sealed class <CoInitEasyList>d__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06006ABB RID: 27323 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006ABB")]
			[Address(RVA = "0x208983C", Offset = "0x208983C", VA = "0x7BBC88983C")]
			[DebuggerHidden]
			public <CoInitEasyList>d__11(int <>1__state)
			{
			}

			// Token: 0x06006ABC RID: 27324 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006ABC")]
			[Address(RVA = "0x208AD5C", Offset = "0x208AD5C", VA = "0x7BBC88AD5C", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06006ABD RID: 27325 RVA: 0x0001E3F0 File Offset: 0x0001C5F0
			[Token(Token = "0x6006ABD")]
			[Address(RVA = "0x208AD60", Offset = "0x208AD60", VA = "0x7BBC88AD60", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x1700091D RID: 2333
			// (get) Token: 0x06006ABE RID: 27326 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700091D")]
			private object Current
			{
				[Token(Token = "0x6006ABE")]
				[Address(RVA = "0x208AE00", Offset = "0x208AE00", VA = "0x7BBC88AE00", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06006ABF RID: 27327 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006ABF")]
			[Address(RVA = "0x208AE08", Offset = "0x208AE08", VA = "0x7BBC88AE08", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x1700091E RID: 2334
			// (get) Token: 0x06006AC0 RID: 27328 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700091E")]
			private object Current
			{
				[Token(Token = "0x6006AC0")]
				[Address(RVA = "0x208AE70", Offset = "0x208AE70", VA = "0x7BBC88AE70", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x040086FD RID: 34557
			[Token(Token = "0x40086FD")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x040086FE RID: 34558
			[Token(Token = "0x40086FE")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x040086FF RID: 34559
			[Token(Token = "0x40086FF")]
			[FieldOffset(Offset = "0x20")]
			public UIAvatarProfileDetailController <>4__this;
		}
	}
}
