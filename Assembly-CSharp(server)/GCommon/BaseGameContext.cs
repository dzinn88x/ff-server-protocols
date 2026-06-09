using System;
using Il2CppDummyDll;

namespace GCommon
{
	// Token: 0x02000EE0 RID: 3808
	[Token(Token = "0x2000EE0")]
	public abstract class BaseGameContext
	{
		// Token: 0x170006A1 RID: 1697
		// (get) Token: 0x060034EF RID: 13551 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060034F0 RID: 13552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006A1")]
		public BaseGame CurrentGame
		{
			[Token(Token = "0x60034EF")]
			[Address(RVA = "0x25E5C6C", Offset = "0x25E5C6C", VA = "0x7BBCDE5C6C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113B4BC", Offset = "0x113B4BC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60034F0")]
			[Address(RVA = "0x25E4704", Offset = "0x25E4704", VA = "0x7BBCDE4704")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113B4CC", Offset = "0x113B4CC")]
			internal set
			{
			}
		}

		// Token: 0x060034F1 RID: 13553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034F1")]
		[Address(RVA = "0x25E470C", Offset = "0x25E470C", VA = "0x7BBCDE470C")]
		public void Init()
		{
		}

		// Token: 0x060034F2 RID: 13554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034F2")]
		[Address(RVA = "0x25E5C74", Offset = "0x25E5C74", VA = "0x7BBCDE5C74")]
		public void Destory()
		{
		}

		// Token: 0x060034F3 RID: 13555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034F3")]
		[Address(RVA = "0x25E5CAC", Offset = "0x25E5CAC", VA = "0x7BBCDE5CAC", Slot = "4")]
		protected virtual void OnInit()
		{
		}

		// Token: 0x060034F4 RID: 13556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034F4")]
		[Address(RVA = "0x25E5CB0", Offset = "0x25E5CB0", VA = "0x7BBCDE5CB0", Slot = "5")]
		protected virtual void OnDestroy()
		{
		}

		// Token: 0x060034F5 RID: 13557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034F5")]
		[Address(RVA = "0x25E5CB4", Offset = "0x25E5CB4", VA = "0x7BBCDE5CB4")]
		protected BaseGameContext()
		{
		}

		// Token: 0x04004869 RID: 18537
		[Token(Token = "0x4004869")]
		[FieldOffset(Offset = "0x10")]
		private bool m_HasInit;

		// Token: 0x0400486A RID: 18538
		[Token(Token = "0x400486A")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112E7F8", Offset = "0x112E7F8")]
		private BaseGame <CurrentGame>k__BackingField;
	}
}
