using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001A6A RID: 6762
	[Token(Token = "0x2001A6A")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F821C", Offset = "0x10F821C")]
	internal class UIMatchResultManualInfoController : UIBaseController, IUIModelDataChangeObserver
	{
		// Token: 0x06008E62 RID: 36450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6008E62")]
		[Address(RVA = "0x1479548", Offset = "0x1479548", VA = "0x7BBBC79548")]
		private UILabel Get()
		{
			return null;
		}

		// Token: 0x06008E63 RID: 36451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008E63")]
		[Address(RVA = "0x147974C", Offset = "0x147974C", VA = "0x7BBBC7974C")]
		private void Push(UILabel label)
		{
		}

		// Token: 0x06008E64 RID: 36452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008E64")]
		[Address(RVA = "0x14798BC", Offset = "0x14798BC", VA = "0x7BBBC798BC")]
		private void ShowUI()
		{
		}

		// Token: 0x06008E65 RID: 36453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008E65")]
		[Address(RVA = "0x1479CA4", Offset = "0x1479CA4", VA = "0x7BBBC79CA4")]
		private void UpdateView()
		{
		}

		// Token: 0x06008E66 RID: 36454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6008E66")]
		[Address(RVA = "0x1479DE0", Offset = "0x1479DE0", VA = "0x7BBBC79DE0")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1144610", Offset = "0x1144610")]
		private IEnumerator LabelRoutine(UILabel label, bool isLastOne)
		{
			return null;
		}

		// Token: 0x06008E67 RID: 36455 RVA: 0x00025FF8 File Offset: 0x000241F8
		[Token(Token = "0x6008E67")]
		[Address(RVA = "0x1479EBC", Offset = "0x1479EBC", VA = "0x7BBBC79EBC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008E68 RID: 36456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008E68")]
		[Address(RVA = "0x1479F0C", Offset = "0x1479F0C", VA = "0x7BBBC79F0C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008E69 RID: 36457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008E69")]
		[Address(RVA = "0x147A05C", Offset = "0x147A05C", VA = "0x7BBBC7A05C", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06008E6A RID: 36458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008E6A")]
		[Address(RVA = "0x147A110", Offset = "0x147A110", VA = "0x7BBBC7A110", Slot = "28")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06008E6B RID: 36459 RVA: 0x00026010 File Offset: 0x00024210
		[Token(Token = "0x6008E6B")]
		[Address(RVA = "0x147A188", Offset = "0x147A188", VA = "0x7BBBC7A188", Slot = "29")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06008E6C RID: 36460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008E6C")]
		[Address(RVA = "0x147A1CC", Offset = "0x147A1CC", VA = "0x7BBBC7A1CC")]
		public UIMatchResultManualInfoController()
		{
		}

		// Token: 0x04009A02 RID: 39426
		[Token(Token = "0x4009A02")]
		[FieldOffset(Offset = "0x58")]
		private UIMatchResultManualInfoView m_View;

		// Token: 0x04009A03 RID: 39427
		[Token(Token = "0x4009A03")]
		[FieldOffset(Offset = "0x60")]
		private List<string> m_Infos;

		// Token: 0x04009A04 RID: 39428
		[Token(Token = "0x4009A04")]
		[FieldOffset(Offset = "0x68")]
		private Vector3 m_OriginPos;

		// Token: 0x04009A05 RID: 39429
		[Token(Token = "0x4009A05")]
		[FieldOffset(Offset = "0x74")]
		private float m_HeightPadding;

		// Token: 0x04009A06 RID: 39430
		[Token(Token = "0x4009A06")]
		[FieldOffset(Offset = "0x78")]
		private Queue<UILabel> m_LabelPool;

		// Token: 0x02001A6B RID: 6763
		[Token(Token = "0x2001A6B")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F8254", Offset = "0x10F8254")]
		private sealed class <LabelRoutine>d__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06008E6D RID: 36461 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008E6D")]
			[Address(RVA = "0x1479E90", Offset = "0x1479E90", VA = "0x7BBBC79E90")]
			[DebuggerHidden]
			public <LabelRoutine>d__9(int <>1__state)
			{
			}

			// Token: 0x06008E6E RID: 36462 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008E6E")]
			[Address(RVA = "0x147A264", Offset = "0x147A264", VA = "0x7BBBC7A264", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06008E6F RID: 36463 RVA: 0x00026028 File Offset: 0x00024228
			[Token(Token = "0x6008E6F")]
			[Address(RVA = "0x147A268", Offset = "0x147A268", VA = "0x7BBBC7A268", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x170009E6 RID: 2534
			// (get) Token: 0x06008E70 RID: 36464 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170009E6")]
			private object Current
			{
				[Token(Token = "0x6008E70")]
				[Address(RVA = "0x147A89C", Offset = "0x147A89C", VA = "0x7BBBC7A89C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06008E71 RID: 36465 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008E71")]
			[Address(RVA = "0x147A8A4", Offset = "0x147A8A4", VA = "0x7BBBC7A8A4", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x170009E7 RID: 2535
			// (get) Token: 0x06008E72 RID: 36466 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170009E7")]
			private object Current
			{
				[Token(Token = "0x6008E72")]
				[Address(RVA = "0x147A90C", Offset = "0x147A90C", VA = "0x7BBBC7A90C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04009A07 RID: 39431
			[Token(Token = "0x4009A07")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04009A08 RID: 39432
			[Token(Token = "0x4009A08")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04009A09 RID: 39433
			[Token(Token = "0x4009A09")]
			[FieldOffset(Offset = "0x20")]
			public UIMatchResultManualInfoController <>4__this;

			// Token: 0x04009A0A RID: 39434
			[Token(Token = "0x4009A0A")]
			[FieldOffset(Offset = "0x28")]
			public UILabel label;

			// Token: 0x04009A0B RID: 39435
			[Token(Token = "0x4009A0B")]
			[FieldOffset(Offset = "0x30")]
			public bool isLastOne;

			// Token: 0x04009A0C RID: 39436
			[Token(Token = "0x4009A0C")]
			[FieldOffset(Offset = "0x34")]
			private Vector3 <targetPos>5__2;

			// Token: 0x04009A0D RID: 39437
			[Token(Token = "0x4009A0D")]
			[FieldOffset(Offset = "0x40")]
			private Vector3 <startPos>5__3;

			// Token: 0x04009A0E RID: 39438
			[Token(Token = "0x4009A0E")]
			[FieldOffset(Offset = "0x4C")]
			private float <time>5__4;
		}
	}
}
