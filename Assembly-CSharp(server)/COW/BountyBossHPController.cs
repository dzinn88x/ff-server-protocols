using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200145C RID: 5212
	[Token(Token = "0x200145C")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10ECBA0", Offset = "0x10ECBA0")]
	public class BountyBossHPController : UIBaseController
	{
		// Token: 0x0600579B RID: 22427 RVA: 0x00019EC0 File Offset: 0x000180C0
		[Token(Token = "0x600579B")]
		[Address(RVA = "0x14E4534", Offset = "0x14E4534", VA = "0x7BBBCE4534")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600579C RID: 22428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600579C")]
		[Address(RVA = "0x14E4584", Offset = "0x14E4584", VA = "0x7BBBCE4584", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600579D RID: 22429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600579D")]
		[Address(RVA = "0x14E48A0", Offset = "0x14E48A0", VA = "0x7BBBCE48A0", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x0600579E RID: 22430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600579E")]
		[Address(RVA = "0x14E482C", Offset = "0x14E482C", VA = "0x7BBBCE482C")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x113F1FC", Offset = "0x113F1FC")]
		private IEnumerator HPFullAnim()
		{
			return null;
		}

		// Token: 0x0600579F RID: 22431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600579F")]
		[Address(RVA = "0x14E4A40", Offset = "0x14E4A40", VA = "0x7BBBCE4A40")]
		private void OnBossHPChanged(object[] data)
		{
		}

		// Token: 0x060057A0 RID: 22432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057A0")]
		[Address(RVA = "0x14E4BE4", Offset = "0x14E4BE4", VA = "0x7BBBCE4BE4")]
		private void OnBossEnhance(params object[] param)
		{
		}

		// Token: 0x060057A1 RID: 22433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057A1")]
		[Address(RVA = "0x14E4D64", Offset = "0x14E4D64", VA = "0x7BBBCE4D64")]
		private void OnBossGod(params object[] param)
		{
		}

		// Token: 0x060057A2 RID: 22434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057A2")]
		[Address(RVA = "0x14E4C4C", Offset = "0x14E4C4C", VA = "0x7BBBCE4C4C")]
		private void DelayHideObject(GameObject obj, float t, bool isHide = true)
		{
		}

		// Token: 0x060057A3 RID: 22435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057A3")]
		[Address(RVA = "0x14E4EDC", Offset = "0x14E4EDC", VA = "0x7BBBCE4EDC")]
		public BountyBossHPController()
		{
		}

		// Token: 0x04007BD2 RID: 31698
		[Token(Token = "0x4007BD2")]
		[FieldOffset(Offset = "0x58")]
		private UIHudBountyWaitingBossHPView m_View;

		// Token: 0x04007BD3 RID: 31699
		[Token(Token = "0x4007BD3")]
		[FieldOffset(Offset = "0x60")]
		private bool m_IsPlayingAnim;

		// Token: 0x0200145D RID: 5213
		[Token(Token = "0x200145D")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10ECBD8", Offset = "0x10ECBD8")]
		private sealed class <HPFullAnim>d__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x060057A4 RID: 22436 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60057A4")]
			[Address(RVA = "0x14E4A14", Offset = "0x14E4A14", VA = "0x7BBBCE4A14")]
			[DebuggerHidden]
			public <HPFullAnim>d__5(int <>1__state)
			{
			}

			// Token: 0x060057A5 RID: 22437 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60057A5")]
			[Address(RVA = "0x14E4F20", Offset = "0x14E4F20", VA = "0x7BBBCE4F20", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x060057A6 RID: 22438 RVA: 0x00019ED8 File Offset: 0x000180D8
			[Token(Token = "0x60057A6")]
			[Address(RVA = "0x14E4F24", Offset = "0x14E4F24", VA = "0x7BBBCE4F24", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x1700089B RID: 2203
			// (get) Token: 0x060057A7 RID: 22439 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700089B")]
			private object Current
			{
				[Token(Token = "0x60057A7")]
				[Address(RVA = "0x14E5098", Offset = "0x14E5098", VA = "0x7BBBCE5098", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x060057A8 RID: 22440 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60057A8")]
			[Address(RVA = "0x14E50A0", Offset = "0x14E50A0", VA = "0x7BBBCE50A0", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x1700089C RID: 2204
			// (get) Token: 0x060057A9 RID: 22441 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700089C")]
			private object Current
			{
				[Token(Token = "0x60057A9")]
				[Address(RVA = "0x14E5108", Offset = "0x14E5108", VA = "0x7BBBCE5108", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04007BD4 RID: 31700
			[Token(Token = "0x4007BD4")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04007BD5 RID: 31701
			[Token(Token = "0x4007BD5")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04007BD6 RID: 31702
			[Token(Token = "0x4007BD6")]
			[FieldOffset(Offset = "0x20")]
			public BountyBossHPController <>4__this;

			// Token: 0x04007BD7 RID: 31703
			[Token(Token = "0x4007BD7")]
			[FieldOffset(Offset = "0x28")]
			private float <beginTime>5__2;
		}

		// Token: 0x0200145E RID: 5214
		[Token(Token = "0x200145E")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10ECBE8", Offset = "0x10ECBE8")]
		private sealed class <>c__DisplayClass9_0
		{
			// Token: 0x060057AA RID: 22442 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60057AA")]
			[Address(RVA = "0x14E4ED4", Offset = "0x14E4ED4", VA = "0x7BBBCE4ED4")]
			public <>c__DisplayClass9_0()
			{
			}

			// Token: 0x060057AB RID: 22443 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60057AB")]
			[Address(RVA = "0x14E4EE4", Offset = "0x14E4EE4", VA = "0x7BBBCE4EE4")]
			internal void <DelayHideObject>b__0()
			{
			}

			// Token: 0x04007BD8 RID: 31704
			[Token(Token = "0x4007BD8")]
			[FieldOffset(Offset = "0x10")]
			public GameObject obj;

			// Token: 0x04007BD9 RID: 31705
			[Token(Token = "0x4007BD9")]
			[FieldOffset(Offset = "0x18")]
			public bool isHide;
		}
	}
}
