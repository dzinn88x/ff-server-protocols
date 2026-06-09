using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

namespace GCommon.Utillities
{
	// Token: 0x02001076 RID: 4214
	[Token(Token = "0x2001076")]
	[Attribute(Name = "DefaultMemberAttribute", RVA = "0x10EAAD4", Offset = "0x10EAAD4")]
	public class CircularBuffer<T> : IList<!0>, ICollection<!0>, IEnumerable<!0>, IEnumerable
	{
		// Token: 0x06004061 RID: 16481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004061")]
		public CircularBuffer(int capacity)
		{
		}

		// Token: 0x17000760 RID: 1888
		// (get) Token: 0x06004062 RID: 16482 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004063 RID: 16483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000760")]
		public T Item
		{
			[Token(Token = "0x6004062")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004063")]
			set
			{
			}
		}

		// Token: 0x17000761 RID: 1889
		// (get) Token: 0x06004064 RID: 16484 RVA: 0x00013DE8 File Offset: 0x00011FE8
		// (set) Token: 0x06004065 RID: 16485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000761")]
		public int Capacity
		{
			[Token(Token = "0x6004064")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113C2BC", Offset = "0x113C2BC")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6004065")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113C2CC", Offset = "0x113C2CC")]
			private set
			{
			}
		}

		// Token: 0x17000762 RID: 1890
		// (get) Token: 0x06004066 RID: 16486 RVA: 0x00013E00 File Offset: 0x00012000
		// (set) Token: 0x06004067 RID: 16487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000762")]
		public int Count
		{
			[Token(Token = "0x6004066")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113C2DC", Offset = "0x113C2DC")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6004067")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113C2EC", Offset = "0x113C2EC")]
			private set
			{
			}
		}

		// Token: 0x06004068 RID: 16488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004068")]
		public void Add(T item)
		{
		}

		// Token: 0x06004069 RID: 16489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004069")]
		public T Add()
		{
			return null;
		}

		// Token: 0x0600406A RID: 16490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600406A")]
		public void Init(Type type)
		{
		}

		// Token: 0x0600406B RID: 16491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600406B")]
		public void Clear()
		{
		}

		// Token: 0x0600406C RID: 16492 RVA: 0x00013E18 File Offset: 0x00012018
		[Token(Token = "0x600406C")]
		public bool Contains(T item)
		{
			return default(bool);
		}

		// Token: 0x0600406D RID: 16493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600406D")]
		public void CopyTo(T[] array, int arrayIndex)
		{
		}

		// Token: 0x0600406E RID: 16494 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600406E")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x113C2FC", Offset = "0x113C2FC")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		// Token: 0x0600406F RID: 16495 RVA: 0x00013E30 File Offset: 0x00012030
		[Token(Token = "0x600406F")]
		public int IndexOf(T item)
		{
			return 0;
		}

		// Token: 0x06004070 RID: 16496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004070")]
		public void Insert(int index, T item)
		{
		}

		// Token: 0x06004071 RID: 16497 RVA: 0x00013E48 File Offset: 0x00012048
		[Token(Token = "0x6004071")]
		public bool Remove(T item)
		{
			return default(bool);
		}

		// Token: 0x06004072 RID: 16498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004072")]
		public void RemoveAt(int index)
		{
		}

		// Token: 0x17000763 RID: 1891
		// (get) Token: 0x06004073 RID: 16499 RVA: 0x00013E60 File Offset: 0x00012060
		[Token(Token = "0x17000763")]
		private bool IsReadOnly
		{
			[Token(Token = "0x6004073")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06004074 RID: 16500 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004074")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x04005009 RID: 20489
		[Token(Token = "0x4005009")]
		[FieldOffset(Offset = "0x0")]
		private T[] m_Buffer;

		// Token: 0x0400500A RID: 20490
		[Token(Token = "0x400500A")]
		[FieldOffset(Offset = "0x0")]
		private int m_Position;

		// Token: 0x0400500B RID: 20491
		[Token(Token = "0x400500B")]
		[FieldOffset(Offset = "0x0")]
		private long m_Version;

		// Token: 0x0400500C RID: 20492
		[Token(Token = "0x400500C")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112EBBC", Offset = "0x112EBBC")]
		private int <Capacity>k__BackingField;

		// Token: 0x0400500D RID: 20493
		[Token(Token = "0x400500D")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112EBCC", Offset = "0x112EBCC")]
		private int <Count>k__BackingField;

		// Token: 0x02001077 RID: 4215
		[Token(Token = "0x2001077")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EAB0C", Offset = "0x10EAB0C")]
		private sealed class <GetEnumerator>d__21 : IEnumerator<!0>, IEnumerator, IDisposable
		{
			// Token: 0x06004075 RID: 16501 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004075")]
			[DebuggerHidden]
			public <GetEnumerator>d__21(int <>1__state)
			{
			}

			// Token: 0x06004076 RID: 16502 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004076")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06004077 RID: 16503 RVA: 0x00013E78 File Offset: 0x00012078
			[Token(Token = "0x6004077")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000764 RID: 1892
			// (get) Token: 0x06004078 RID: 16504 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000764")]
			private T Current
			{
				[Token(Token = "0x6004078")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06004079 RID: 16505 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004079")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000765 RID: 1893
			// (get) Token: 0x0600407A RID: 16506 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000765")]
			private object Current
			{
				[Token(Token = "0x600407A")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0400500E RID: 20494
			[Token(Token = "0x400500E")]
			[FieldOffset(Offset = "0x0")]
			private int <>1__state;

			// Token: 0x0400500F RID: 20495
			[Token(Token = "0x400500F")]
			[FieldOffset(Offset = "0x0")]
			private T <>2__current;

			// Token: 0x04005010 RID: 20496
			[Token(Token = "0x4005010")]
			[FieldOffset(Offset = "0x0")]
			public CircularBuffer<T> <>4__this;

			// Token: 0x04005011 RID: 20497
			[Token(Token = "0x4005011")]
			[FieldOffset(Offset = "0x0")]
			private long <version>5__2;

			// Token: 0x04005012 RID: 20498
			[Token(Token = "0x4005012")]
			[FieldOffset(Offset = "0x0")]
			private int <i>5__3;
		}
	}
}
