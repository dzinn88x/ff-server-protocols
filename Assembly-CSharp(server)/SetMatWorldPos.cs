using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000052 RID: 82
[Token(Token = "0x2000052")]
public class SetMatWorldPos : MonoBehaviour
{
	// Token: 0x060000EA RID: 234 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000EA")]
	[Address(RVA = "0x2258154", Offset = "0x2258154", VA = "0x7BBCA58154")]
	private void Awake()
	{
	}

	// Token: 0x060000EB RID: 235 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000EB")]
	[Address(RVA = "0x2258294", Offset = "0x2258294", VA = "0x7BBCA58294")]
	private void OnEnable()
	{
	}

	// Token: 0x060000EC RID: 236 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000EC")]
	[Address(RVA = "0x2258158", Offset = "0x2258158", VA = "0x7BBCA58158")]
	private void InitRefs()
	{
	}

	// Token: 0x060000ED RID: 237 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000ED")]
	[Address(RVA = "0x22582C0", Offset = "0x22582C0", VA = "0x7BBCA582C0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1131F20", Offset = "0x1131F20")]
	private IEnumerator DoSet()
	{
		return null;
	}

	// Token: 0x060000EE RID: 238 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000EE")]
	[Address(RVA = "0x2258360", Offset = "0x2258360", VA = "0x7BBCA58360")]
	public SetMatWorldPos()
	{
	}

	// Token: 0x0400010E RID: 270
	[Token(Token = "0x400010E")]
	[FieldOffset(Offset = "0x18")]
	public Material Mat;

	// Token: 0x0400010F RID: 271
	[Token(Token = "0x400010F")]
	[FieldOffset(Offset = "0x20")]
	protected Transform CachedTrans;

	// Token: 0x02000053 RID: 83
	[Token(Token = "0x2000053")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E1B04", Offset = "0x10E1B04")]
	private sealed class <DoSet>d__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060000EF RID: 239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x2258334", Offset = "0x2258334", VA = "0x7BBCA58334")]
		[DebuggerHidden]
		public <DoSet>d__5(int <>1__state)
		{
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x2258368", Offset = "0x2258368", VA = "0x7BBCA58368", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00002208 File Offset: 0x00000408
		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x225836C", Offset = "0x225836C", VA = "0x7BBCA5836C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x060000F2 RID: 242 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000008")]
		private object Current
		{
			[Token(Token = "0x60000F2")]
			[Address(RVA = "0x22584D0", Offset = "0x22584D0", VA = "0x7BBCA584D0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x22584D8", Offset = "0x22584D8", VA = "0x7BBCA584D8", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x060000F4 RID: 244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000009")]
		private object Current
		{
			[Token(Token = "0x60000F4")]
			[Address(RVA = "0x2258540", Offset = "0x2258540", VA = "0x7BBCA58540", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000110 RID: 272
		[Token(Token = "0x4000110")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04000111 RID: 273
		[Token(Token = "0x4000111")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04000112 RID: 274
		[Token(Token = "0x4000112")]
		[FieldOffset(Offset = "0x20")]
		public SetMatWorldPos <>4__this;
	}
}
