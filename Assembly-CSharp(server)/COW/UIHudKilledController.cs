using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020018FB RID: 6395
	[Token(Token = "0x20018FB")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F55AC", Offset = "0x10F55AC")]
	internal class UIHudKilledController : UIBaseController, IUIModelDataChangeObserver
	{
		// Token: 0x06008063 RID: 32867 RVA: 0x00023010 File Offset: 0x00021210
		[Token(Token = "0x6008063")]
		[Address(RVA = "0x1C53600", Offset = "0x1C53600", VA = "0x7BBC453600")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008064 RID: 32868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008064")]
		[Address(RVA = "0x1C53650", Offset = "0x1C53650", VA = "0x7BBC453650", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008065 RID: 32869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008065")]
		[Address(RVA = "0x1C53890", Offset = "0x1C53890", VA = "0x7BBC453890", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06008066 RID: 32870 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6008066")]
		[Address(RVA = "0x1C53988", Offset = "0x1C53988", VA = "0x7BBC453988")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1142FA0", Offset = "0x1142FA0")]
		private IEnumerator RemoveKillHint(float delayTime, GameObject hint_object)
		{
			return null;
		}

		// Token: 0x06008067 RID: 32871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008067")]
		[Address(RVA = "0x1C53A6C", Offset = "0x1C53A6C", VA = "0x7BBC453A6C")]
		private void OnHeadShot(object[] data)
		{
		}

		// Token: 0x06008068 RID: 32872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008068")]
		[Address(RVA = "0x1C53E7C", Offset = "0x1C53E7C", VA = "0x7BBC453E7C", Slot = "28")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06008069 RID: 32873 RVA: 0x00023028 File Offset: 0x00021228
		[Token(Token = "0x6008069")]
		[Address(RVA = "0x1C54118", Offset = "0x1C54118", VA = "0x7BBC454118", Slot = "29")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x0600806A RID: 32874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600806A")]
		[Address(RVA = "0x1C53BB8", Offset = "0x1C53BB8", VA = "0x7BBC453BB8")]
		private void TargetPlayerKilledIcon(bool isHeadShot)
		{
		}

		// Token: 0x0600806B RID: 32875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600806B")]
		[Address(RVA = "0x1C54160", Offset = "0x1C54160", VA = "0x7BBC454160")]
		public UIHudKilledController()
		{
		}

		// Token: 0x0400929C RID: 37532
		[Token(Token = "0x400929C")]
		[FieldOffset(Offset = "0x58")]
		private UIHudKilledView m_View;

		// Token: 0x0400929D RID: 37533
		[Token(Token = "0x400929D")]
		[FieldOffset(Offset = "0x60")]
		private UIModelMatch m_MatchModel;

		// Token: 0x0400929E RID: 37534
		[Token(Token = "0x400929E")]
		[FieldOffset(Offset = "0x68")]
		private bool isCoroutineRunning;

		// Token: 0x020018FC RID: 6396
		[Token(Token = "0x20018FC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F55E4", Offset = "0x10F55E4")]
		private sealed class <RemoveKillHint>d__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x0600806C RID: 32876 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600806C")]
			[Address(RVA = "0x1C53A40", Offset = "0x1C53A40", VA = "0x7BBC453A40")]
			[DebuggerHidden]
			public <RemoveKillHint>d__6(int <>1__state)
			{
			}

			// Token: 0x0600806D RID: 32877 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600806D")]
			[Address(RVA = "0x1C54168", Offset = "0x1C54168", VA = "0x7BBC454168", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x0600806E RID: 32878 RVA: 0x00023040 File Offset: 0x00021240
			[Token(Token = "0x600806E")]
			[Address(RVA = "0x1C5416C", Offset = "0x1C5416C", VA = "0x7BBC45416C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x170009A0 RID: 2464
			// (get) Token: 0x0600806F RID: 32879 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170009A0")]
			private object Current
			{
				[Token(Token = "0x600806F")]
				[Address(RVA = "0x1C54284", Offset = "0x1C54284", VA = "0x7BBC454284", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06008070 RID: 32880 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008070")]
			[Address(RVA = "0x1C5428C", Offset = "0x1C5428C", VA = "0x7BBC45428C", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x170009A1 RID: 2465
			// (get) Token: 0x06008071 RID: 32881 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170009A1")]
			private object Current
			{
				[Token(Token = "0x6008071")]
				[Address(RVA = "0x1C542F4", Offset = "0x1C542F4", VA = "0x7BBC4542F4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0400929F RID: 37535
			[Token(Token = "0x400929F")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x040092A0 RID: 37536
			[Token(Token = "0x40092A0")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x040092A1 RID: 37537
			[Token(Token = "0x40092A1")]
			[FieldOffset(Offset = "0x20")]
			public float delayTime;

			// Token: 0x040092A2 RID: 37538
			[Token(Token = "0x40092A2")]
			[FieldOffset(Offset = "0x28")]
			public GameObject hint_object;

			// Token: 0x040092A3 RID: 37539
			[Token(Token = "0x40092A3")]
			[FieldOffset(Offset = "0x30")]
			public UIHudKilledController <>4__this;
		}
	}
}
