using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020016CE RID: 5838
	[Token(Token = "0x20016CE")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F0D54", Offset = "0x10F0D54")]
	public class UIAvatarSuitListController : UIBaseController, IEasyList
	{
		// Token: 0x06006B57 RID: 27479 RVA: 0x0001E648 File Offset: 0x0001C848
		[Token(Token = "0x6006B57")]
		[Address(RVA = "0x1E51DA4", Offset = "0x1E51DA4", VA = "0x7BBC651DA4")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006B58 RID: 27480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B58")]
		[Address(RVA = "0x1E51DF4", Offset = "0x1E51DF4", VA = "0x7BBC651DF4", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006B59 RID: 27481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B59")]
		[Address(RVA = "0x1E52034", Offset = "0x1E52034", VA = "0x7BBC652034", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06006B5A RID: 27482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B5A")]
		[Address(RVA = "0x1E52154", Offset = "0x1E52154", VA = "0x7BBC652154")]
		public void SetData(uint AvatarID, uint curSuitID)
		{
		}

		// Token: 0x06006B5B RID: 27483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B5B")]
		[Address(RVA = "0x1E52160", Offset = "0x1E52160", VA = "0x7BBC652160")]
		public void RefreshData()
		{
		}

		// Token: 0x06006B5C RID: 27484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B5C")]
		[Address(RVA = "0x1E5252C", Offset = "0x1E5252C", VA = "0x7BBC65252C")]
		public void OnSwitchSuit(params object[] param)
		{
		}

		// Token: 0x06006B5D RID: 27485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B5D")]
		[Address(RVA = "0x1E525F8", Offset = "0x1E525F8", VA = "0x7BBC6525F8")]
		public void OnSuitChanged(params object[] param)
		{
		}

		// Token: 0x06006B5E RID: 27486 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B5E")]
		[Address(RVA = "0x1E525FC", Offset = "0x1E525FC", VA = "0x7BBC6525FC", Slot = "28")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x06006B5F RID: 27487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B5F")]
		[Address(RVA = "0x1E52690", Offset = "0x1E52690", VA = "0x7BBC652690", Slot = "29")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x06006B60 RID: 27488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B60")]
		[Address(RVA = "0x1E526C0", Offset = "0x1E526C0", VA = "0x7BBC6526C0")]
		public void OnResetClothesClick()
		{
		}

		// Token: 0x06006B61 RID: 27489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B61")]
		[Address(RVA = "0x1E5276C", Offset = "0x1E5276C", VA = "0x7BBC65276C")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1141104", Offset = "0x1141104")]
		private IEnumerator CoResetClothes()
		{
			return null;
		}

		// Token: 0x06006B62 RID: 27490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B62")]
		[Address(RVA = "0x1E5280C", Offset = "0x1E5280C", VA = "0x7BBC65280C")]
		public UIAvatarSuitListController()
		{
		}

		// Token: 0x0400874C RID: 34636
		[Token(Token = "0x400874C")]
		[FieldOffset(Offset = "0x58")]
		private uint m_CurrentSuitID;

		// Token: 0x0400874D RID: 34637
		[Token(Token = "0x400874D")]
		[FieldOffset(Offset = "0x60")]
		private UIAvatarSuitListView m_View;

		// Token: 0x0400874E RID: 34638
		[Token(Token = "0x400874E")]
		[FieldOffset(Offset = "0x68")]
		private uint m_AvatarID;

		// Token: 0x0400874F RID: 34639
		[Token(Token = "0x400874F")]
		[FieldOffset(Offset = "0x70")]
		private UIModelAvatar m_ModelAvatar;

		// Token: 0x020016CF RID: 5839
		[Token(Token = "0x20016CF")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F0D8C", Offset = "0x10F0D8C")]
		private sealed class <CoResetClothes>d__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06006B63 RID: 27491 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006B63")]
			[Address(RVA = "0x1E527E0", Offset = "0x1E527E0", VA = "0x7BBC6527E0")]
			[DebuggerHidden]
			public <CoResetClothes>d__14(int <>1__state)
			{
			}

			// Token: 0x06006B64 RID: 27492 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006B64")]
			[Address(RVA = "0x1E52814", Offset = "0x1E52814", VA = "0x7BBC652814", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06006B65 RID: 27493 RVA: 0x0001E660 File Offset: 0x0001C860
			[Token(Token = "0x6006B65")]
			[Address(RVA = "0x1E52818", Offset = "0x1E52818", VA = "0x7BBC652818", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000924 RID: 2340
			// (get) Token: 0x06006B66 RID: 27494 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000924")]
			private object Current
			{
				[Token(Token = "0x6006B66")]
				[Address(RVA = "0x1E52880", Offset = "0x1E52880", VA = "0x7BBC652880", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06006B67 RID: 27495 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006B67")]
			[Address(RVA = "0x1E52888", Offset = "0x1E52888", VA = "0x7BBC652888", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000925 RID: 2341
			// (get) Token: 0x06006B68 RID: 27496 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000925")]
			private object Current
			{
				[Token(Token = "0x6006B68")]
				[Address(RVA = "0x1E528F0", Offset = "0x1E528F0", VA = "0x7BBC6528F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04008750 RID: 34640
			[Token(Token = "0x4008750")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04008751 RID: 34641
			[Token(Token = "0x4008751")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04008752 RID: 34642
			[Token(Token = "0x4008752")]
			[FieldOffset(Offset = "0x20")]
			public UIAvatarSuitListController <>4__this;
		}
	}
}
