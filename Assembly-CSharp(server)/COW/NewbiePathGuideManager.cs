using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001CEC RID: 7404
	[Token(Token = "0x2001CEC")]
	internal class NewbiePathGuideManager : SingletonModule<NewbiePathGuideManager>
	{
		// Token: 0x17000A9A RID: 2714
		// (get) Token: 0x0600A180 RID: 41344 RVA: 0x0002A678 File Offset: 0x00028878
		[Token(Token = "0x17000A9A")]
		public bool InGuideProgress
		{
			[Token(Token = "0x600A180")]
			[Address(RVA = "0x1A5EF50", Offset = "0x1A5EF50", VA = "0x7BBC25EF50")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000A9B RID: 2715
		// (get) Token: 0x0600A182 RID: 41346 RVA: 0x0002A690 File Offset: 0x00028890
		// (set) Token: 0x0600A181 RID: 41345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A9B")]
		public int GuideProgress
		{
			[Token(Token = "0x600A182")]
			[Address(RVA = "0x1A65460", Offset = "0x1A65460", VA = "0x7BBC265460")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114559C", Offset = "0x114559C")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600A181")]
			[Address(RVA = "0x1A65468", Offset = "0x1A65468", VA = "0x7BBC265468")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114558C", Offset = "0x114558C")]
			private set
			{
			}
		}

		// Token: 0x17000A9C RID: 2716
		// (get) Token: 0x0600A184 RID: 41348 RVA: 0x0002A6A8 File Offset: 0x000288A8
		// (set) Token: 0x0600A183 RID: 41347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A9C")]
		public ENewbieGuideType CurNewbieGuideType
		{
			[Token(Token = "0x600A184")]
			[Address(RVA = "0x1A65478", Offset = "0x1A65478", VA = "0x7BBC265478")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11455BC", Offset = "0x11455BC")]
			get
			{
				return ENewbieGuideType.None;
			}
			[Token(Token = "0x600A183")]
			[Address(RVA = "0x1A65470", Offset = "0x1A65470", VA = "0x7BBC265470")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11455AC", Offset = "0x11455AC")]
			private set
			{
			}
		}

		// Token: 0x0600A185 RID: 41349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A185")]
		[Address(RVA = "0x1A65480", Offset = "0x1A65480", VA = "0x7BBC265480", Slot = "6")]
		protected override void OnInit()
		{
		}

		// Token: 0x0600A186 RID: 41350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A186")]
		[Address(RVA = "0x1A6548C", Offset = "0x1A6548C", VA = "0x7BBC26548C", Slot = "7")]
		protected override void OnCleanup()
		{
		}

		// Token: 0x0600A187 RID: 41351 RVA: 0x0002A6C0 File Offset: 0x000288C0
		[Token(Token = "0x600A187")]
		[Address(RVA = "0x1A65490", Offset = "0x1A65490", VA = "0x7BBC265490")]
		public int GetTotalGuideSteps(ENewbieGuideType type)
		{
			return 0;
		}

		// Token: 0x0600A188 RID: 41352 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A188")]
		[Address(RVA = "0x1A6552C", Offset = "0x1A6552C", VA = "0x7BBC26552C")]
		public string GetCurGuideTips()
		{
			return null;
		}

		// Token: 0x0600A189 RID: 41353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A189")]
		[Address(RVA = "0x1A6568C", Offset = "0x1A6568C", VA = "0x7BBC26568C")]
		public void StartGuide(ENewbieGuideType type)
		{
		}

		// Token: 0x0600A18A RID: 41354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A18A")]
		[Address(RVA = "0x1A65884", Offset = "0x1A65884", VA = "0x7BBC265884")]
		public void BoostCurGuideProgress()
		{
		}

		// Token: 0x0600A18B RID: 41355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A18B")]
		[Address(RVA = "0x1A65890", Offset = "0x1A65890", VA = "0x7BBC265890")]
		public void ForceStopAllGuide()
		{
		}

		// Token: 0x0600A18C RID: 41356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A18C")]
		[Address(RVA = "0x1A65694", Offset = "0x1A65694", VA = "0x7BBC265694")]
		public void SetGuideProgress(ENewbieGuideType type, int value)
		{
		}

		// Token: 0x0600A18D RID: 41357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A18D")]
		[Address(RVA = "0x1A6589C", Offset = "0x1A6589C", VA = "0x7BBC26589C")]
		private void StopOldGuide()
		{
		}

		// Token: 0x0600A18E RID: 41358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A18E")]
		[Address(RVA = "0x1A659CC", Offset = "0x1A659CC", VA = "0x7BBC2659CC")]
		public NewbiePathGuideManager()
		{
		}

		// Token: 0x0400A7FA RID: 43002
		[Token(Token = "0x400A7FA")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112FC4C", Offset = "0x112FC4C")]
		private int <GuideProgress>k__BackingField;

		// Token: 0x0400A7FB RID: 43003
		[Token(Token = "0x400A7FB")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112FC5C", Offset = "0x112FC5C")]
		private ENewbieGuideType <CurNewbieGuideType>k__BackingField;

		// Token: 0x0400A7FC RID: 43004
		[Token(Token = "0x400A7FC")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<ENewbieGuideType, string[]> m_GuideTips;
	}
}
