using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

namespace GCommon
{
	// Token: 0x02000ECE RID: 3790
	[Token(Token = "0x2000ECE")]
	public class RingBuffer<T> : IEnumerable<!0>, IEnumerable, ICollection<!0>, ICollection
	{
		// Token: 0x17000688 RID: 1672
		// (get) Token: 0x06003446 RID: 13382 RVA: 0x0000F9F0 File Offset: 0x0000DBF0
		[Token(Token = "0x17000688")]
		public bool AllowOverflow
		{
			[Token(Token = "0x6003446")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000689 RID: 1673
		// (get) Token: 0x06003447 RID: 13383 RVA: 0x0000FA08 File Offset: 0x0000DC08
		[Token(Token = "0x17000689")]
		public int Capacity
		{
			[Token(Token = "0x6003447")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700068A RID: 1674
		// (get) Token: 0x06003448 RID: 13384 RVA: 0x0000FA20 File Offset: 0x0000DC20
		[Token(Token = "0x1700068A")]
		public int Size
		{
			[Token(Token = "0x6003448")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06003449 RID: 13385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003449")]
		public T Get()
		{
			return null;
		}

		// Token: 0x0600344A RID: 13386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600344A")]
		public void Put(T item)
		{
		}

		// Token: 0x0600344B RID: 13387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600344B")]
		protected void addToBuffer(T toAdd, bool overflow)
		{
		}

		// Token: 0x0600344C RID: 13388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600344C")]
		public RingBuffer()
		{
		}

		// Token: 0x0600344D RID: 13389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600344D")]
		public RingBuffer(int capacity)
		{
		}

		// Token: 0x0600344E RID: 13390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600344E")]
		public RingBuffer(int capacity, bool overflow)
		{
		}

		// Token: 0x0600344F RID: 13391 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600344F")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x113B344", Offset = "0x113B344")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06003450 RID: 13392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003450")]
		private IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06003451 RID: 13393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003451")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x1700068B RID: 1675
		// (get) Token: 0x06003452 RID: 13394 RVA: 0x0000FA38 File Offset: 0x0000DC38
		[Token(Token = "0x1700068B")]
		public int Count
		{
			[Token(Token = "0x6003452")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700068C RID: 1676
		// (get) Token: 0x06003453 RID: 13395 RVA: 0x0000FA50 File Offset: 0x0000DC50
		[Token(Token = "0x1700068C")]
		public bool IsReadOnly
		{
			[Token(Token = "0x6003453")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06003454 RID: 13396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003454")]
		public void Add(T item)
		{
		}

		// Token: 0x06003455 RID: 13397 RVA: 0x0000FA68 File Offset: 0x0000DC68
		[Token(Token = "0x6003455")]
		public bool Contains(T item)
		{
			return default(bool);
		}

		// Token: 0x06003456 RID: 13398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003456")]
		public void Clear()
		{
		}

		// Token: 0x06003457 RID: 13399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003457")]
		public void CopyTo(T[] array, int arrayIndex)
		{
		}

		// Token: 0x06003458 RID: 13400 RVA: 0x0000FA80 File Offset: 0x0000DC80
		[Token(Token = "0x6003458")]
		public bool Remove(T item)
		{
			return default(bool);
		}

		// Token: 0x1700068D RID: 1677
		// (get) Token: 0x06003459 RID: 13401 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700068D")]
		public object SyncRoot
		{
			[Token(Token = "0x6003459")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700068E RID: 1678
		// (get) Token: 0x0600345A RID: 13402 RVA: 0x0000FA98 File Offset: 0x0000DC98
		[Token(Token = "0x1700068E")]
		public bool IsSynchronized
		{
			[Token(Token = "0x600345A")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600345B RID: 13403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600345B")]
		private void CopyTo(Array array, int index)
		{
		}

		// Token: 0x04004805 RID: 18437
		[Token(Token = "0x4004805")]
		[FieldOffset(Offset = "0x0")]
		protected int head;

		// Token: 0x04004806 RID: 18438
		[Token(Token = "0x4004806")]
		[FieldOffset(Offset = "0x0")]
		protected int tail;

		// Token: 0x04004807 RID: 18439
		[Token(Token = "0x4004807")]
		[FieldOffset(Offset = "0x0")]
		protected int size;

		// Token: 0x04004808 RID: 18440
		[Token(Token = "0x4004808")]
		[FieldOffset(Offset = "0x0")]
		protected T[] buffer;

		// Token: 0x04004809 RID: 18441
		[Token(Token = "0x4004809")]
		[FieldOffset(Offset = "0x0")]
		private bool allowOverflow;

		// Token: 0x02000ECF RID: 3791
		[Token(Token = "0x2000ECF")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EA304", Offset = "0x10EA304")]
		private sealed class <GetEnumerator>d__17 : IEnumerator<!0>, IEnumerator, IDisposable
		{
			// Token: 0x0600345C RID: 13404 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600345C")]
			[DebuggerHidden]
			public <GetEnumerator>d__17(int <>1__state)
			{
			}

			// Token: 0x0600345D RID: 13405 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600345D")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x0600345E RID: 13406 RVA: 0x0000FAB0 File Offset: 0x0000DCB0
			[Token(Token = "0x600345E")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x1700068F RID: 1679
			// (get) Token: 0x0600345F RID: 13407 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700068F")]
			private T Current
			{
				[Token(Token = "0x600345F")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06003460 RID: 13408 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003460")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000690 RID: 1680
			// (get) Token: 0x06003461 RID: 13409 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000690")]
			private object Current
			{
				[Token(Token = "0x6003461")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0400480A RID: 18442
			[Token(Token = "0x400480A")]
			[FieldOffset(Offset = "0x0")]
			private int <>1__state;

			// Token: 0x0400480B RID: 18443
			[Token(Token = "0x400480B")]
			[FieldOffset(Offset = "0x0")]
			private T <>2__current;

			// Token: 0x0400480C RID: 18444
			[Token(Token = "0x400480C")]
			[FieldOffset(Offset = "0x0")]
			public RingBuffer<T> <>4__this;

			// Token: 0x0400480D RID: 18445
			[Token(Token = "0x400480D")]
			[FieldOffset(Offset = "0x0")]
			private int <_index>5__2;

			// Token: 0x0400480E RID: 18446
			[Token(Token = "0x400480E")]
			[FieldOffset(Offset = "0x0")]
			private int <i>5__3;
		}
	}
}
