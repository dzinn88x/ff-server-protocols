using System;
using Il2CppDummyDll;

namespace GarenaMSDK
{
	// Token: 0x02002BF2 RID: 11250
	[Token(Token = "0x2002BF2")]
	internal class LoadSomeIAPItems : SDKIAPTaskInstance
	{
		// Token: 0x0600F8E1 RID: 63713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F8E1")]
		[Address(RVA = "0x224FEDC", Offset = "0x224FEDC", VA = "0x7BBCA4FEDC")]
		public LoadSomeIAPItems(SDKIAPTaskInfo info)
		{
		}

		// Token: 0x1700121B RID: 4635
		// (get) Token: 0x0600F8E2 RID: 63714 RVA: 0x00047B08 File Offset: 0x00045D08
		[Token(Token = "0x1700121B")]
		public override SDKIAPTask Task
		{
			[Token(Token = "0x600F8E2")]
			[Address(RVA = "0x224FEE4", Offset = "0x224FEE4", VA = "0x7BBCA4FEE4", Slot = "4")]
			get
			{
				return SDKIAPTask.None;
			}
		}

		// Token: 0x0600F8E3 RID: 63715 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F8E3")]
		[Address(RVA = "0x224FEEC", Offset = "0x224FEEC", VA = "0x7BBCA4FEEC", Slot = "9")]
		internal override string IdentifySelf()
		{
			return null;
		}

		// Token: 0x0600F8E4 RID: 63716 RVA: 0x00047B20 File Offset: 0x00045D20
		[Token(Token = "0x600F8E4")]
		[Address(RVA = "0x22502B8", Offset = "0x22502B8", VA = "0x7BBCA502B8", Slot = "11")]
		public override bool IsDuplicateOf(SDKIAPTaskInstance peer)
		{
			return default(bool);
		}

		// Token: 0x0600F8E5 RID: 63717 RVA: 0x00047B38 File Offset: 0x00045D38
		[Token(Token = "0x600F8E5")]
		[Address(RVA = "0x2250390", Offset = "0x2250390", VA = "0x7BBCA50390", Slot = "12")]
		public override bool CanFinishWith(SDKIAPTaskInstance peer)
		{
			return default(bool);
		}

		// Token: 0x0600F8E6 RID: 63718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F8E6")]
		[Address(RVA = "0x2250398", Offset = "0x2250398", VA = "0x7BBCA50398", Slot = "13")]
		protected override void Start()
		{
		}

		// Token: 0x0600F8E7 RID: 63719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F8E7")]
		[Address(RVA = "0x2250534", Offset = "0x2250534", VA = "0x7BBCA50534")]
		private void OnLoadedIAPItems(SDKIAP.IAPItem[] items, ErrorCode errorCode, string errorMessage)
		{
		}

		// Token: 0x0600F8E8 RID: 63720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F8E8")]
		[Address(RVA = "0x2250634", Offset = "0x2250634", VA = "0x7BBCA50634", Slot = "14")]
		protected override void Succeed()
		{
		}

		// Token: 0x0600F8E9 RID: 63721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F8E9")]
		[Address(RVA = "0x22506E8", Offset = "0x22506E8", VA = "0x7BBCA506E8", Slot = "15")]
		protected override void Fail()
		{
		}

		// Token: 0x0600F8EA RID: 63722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F8EA")]
		[Address(RVA = "0x225079C", Offset = "0x225079C", VA = "0x7BBCA5079C", Slot = "16")]
		protected override void Destroy()
		{
		}

		// Token: 0x0600F8EB RID: 63723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F8EB")]
		[Address(RVA = "0x2250814", Offset = "0x2250814", VA = "0x7BBCA50814")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114BC78", Offset = "0x114BC78")]
		private void <Succeed>b__13_0(LoadSomeIAPItems i)
		{
		}

		// Token: 0x0600F8EC RID: 63724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F8EC")]
		[Address(RVA = "0x22508C0", Offset = "0x22508C0", VA = "0x7BBCA508C0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114BC88", Offset = "0x114BC88")]
		private void <Fail>b__14_0(LoadSomeIAPItems i)
		{
		}

		// Token: 0x04011CAF RID: 72879
		[Token(Token = "0x4011CAF")]
		[FieldOffset(Offset = "0x28")]
		public bool Localized;

		// Token: 0x04011CB0 RID: 72880
		[Token(Token = "0x4011CB0")]
		[FieldOffset(Offset = "0x30")]
		public int[] ItemIds;

		// Token: 0x04011CB1 RID: 72881
		[Token(Token = "0x4011CB1")]
		[FieldOffset(Offset = "0x38")]
		public long[] RebateIds;

		// Token: 0x04011CB2 RID: 72882
		[Token(Token = "0x4011CB2")]
		[FieldOffset(Offset = "0x40")]
		public SDKIAP.IAPItem[] _Products;

		// Token: 0x04011CB3 RID: 72883
		[Token(Token = "0x4011CB3")]
		[FieldOffset(Offset = "0x48")]
		public Action<SDKIAPTaskInfo, SDKIAPTaskResult, SDKIAP.IAPItem[]> OnDone;

		// Token: 0x02002BF3 RID: 11251
		[Token(Token = "0x2002BF3")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FF7E4", Offset = "0x10FF7E4")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600F8EE RID: 63726 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F8EE")]
			[Address(RVA = "0x22509D0", Offset = "0x22509D0", VA = "0x7BBCA509D0")]
			public <>c()
			{
			}

			// Token: 0x0600F8EF RID: 63727 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600F8EF")]
			[Address(RVA = "0x22509D8", Offset = "0x22509D8", VA = "0x7BBCA509D8")]
			internal string <IdentifySelf>b__8_0(int id)
			{
				return null;
			}

			// Token: 0x0600F8F0 RID: 63728 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600F8F0")]
			[Address(RVA = "0x2250A00", Offset = "0x2250A00", VA = "0x7BBCA50A00")]
			internal string <IdentifySelf>b__8_1(long id)
			{
				return null;
			}

			// Token: 0x04011CB4 RID: 72884
			[Token(Token = "0x4011CB4")]
			[FieldOffset(Offset = "0x0")]
			public static readonly LoadSomeIAPItems.<>c <>9;

			// Token: 0x04011CB5 RID: 72885
			[Token(Token = "0x4011CB5")]
			[FieldOffset(Offset = "0x8")]
			public static Converter<int, string> <>9__8_0;

			// Token: 0x04011CB6 RID: 72886
			[Token(Token = "0x4011CB6")]
			[FieldOffset(Offset = "0x10")]
			public static Converter<long, string> <>9__8_1;
		}
	}
}
