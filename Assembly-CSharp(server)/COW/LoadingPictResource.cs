using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200112B RID: 4395
	[Token(Token = "0x200112B")]
	public class LoadingPictResource
	{
		// Token: 0x17000814 RID: 2068
		// (get) Token: 0x060044B2 RID: 17586 RVA: 0x00015090 File Offset: 0x00013290
		// (set) Token: 0x060044B3 RID: 17587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000814")]
		public ResourceID PrefabRes
		{
			[Token(Token = "0x60044B2")]
			[Address(RVA = "0x14060B0", Offset = "0x14060B0", VA = "0x7BBBC060B0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113D878", Offset = "0x113D878")]
			get
			{
				return default(ResourceID);
			}
			[Token(Token = "0x60044B3")]
			[Address(RVA = "0x14060B8", Offset = "0x14060B8", VA = "0x7BBBC060B8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113D888", Offset = "0x113D888")]
			private set
			{
			}
		}

		// Token: 0x17000815 RID: 2069
		// (get) Token: 0x060044B4 RID: 17588 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060044B5 RID: 17589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000815")]
		public string CDNUrl
		{
			[Token(Token = "0x60044B4")]
			[Address(RVA = "0x14060C0", Offset = "0x14060C0", VA = "0x7BBBC060C0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113D898", Offset = "0x113D898")]
			get
			{
				return null;
			}
			[Token(Token = "0x60044B5")]
			[Address(RVA = "0x14060C8", Offset = "0x14060C8", VA = "0x7BBBC060C8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113D8A8", Offset = "0x113D8A8")]
			private set
			{
			}
		}

		// Token: 0x060044B6 RID: 17590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044B6")]
		[Address(RVA = "0x1405738", Offset = "0x1405738", VA = "0x7BBBC05738")]
		public LoadingPictResource(ResourceID res)
		{
		}

		// Token: 0x060044B7 RID: 17591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044B7")]
		[Address(RVA = "0x1405D50", Offset = "0x1405D50", VA = "0x7BBBC05D50")]
		public LoadingPictResource(string url)
		{
		}

		// Token: 0x040054E0 RID: 21728
		[Token(Token = "0x40054E0")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112F54C", Offset = "0x112F54C")]
		private ResourceID <PrefabRes>k__BackingField;

		// Token: 0x040054E1 RID: 21729
		[Token(Token = "0x40054E1")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112F55C", Offset = "0x112F55C")]
		private string <CDNUrl>k__BackingField;
	}
}
