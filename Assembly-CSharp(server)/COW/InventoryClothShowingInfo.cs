using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001ED2 RID: 7890
	[Token(Token = "0x2001ED2")]
	public class InventoryClothShowingInfo : IComparable<InventoryClothShowingInfo>
	{
		// Token: 0x17000B6F RID: 2927
		// (get) Token: 0x0600AD29 RID: 44329 RVA: 0x0002FE08 File Offset: 0x0002E008
		// (set) Token: 0x0600AD2A RID: 44330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B6F")]
		public bool IsLegend
		{
			[Token(Token = "0x600AD29")]
			[Address(RVA = "0x13F31EC", Offset = "0x13F31EC", VA = "0x7BBBBF31EC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114647C", Offset = "0x114647C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600AD2A")]
			[Address(RVA = "0x13F31F4", Offset = "0x13F31F4", VA = "0x7BBBBF31F4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114648C", Offset = "0x114648C")]
			private set
			{
			}
		}

		// Token: 0x17000B70 RID: 2928
		// (get) Token: 0x0600AD2B RID: 44331 RVA: 0x0002FE20 File Offset: 0x0002E020
		// (set) Token: 0x0600AD2C RID: 44332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B70")]
		public uint LegendType
		{
			[Token(Token = "0x600AD2B")]
			[Address(RVA = "0x13F3200", Offset = "0x13F3200", VA = "0x7BBBBF3200")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114649C", Offset = "0x114649C")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x600AD2C")]
			[Address(RVA = "0x13F3208", Offset = "0x13F3208", VA = "0x7BBBBF3208")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11464AC", Offset = "0x11464AC")]
			private set
			{
			}
		}

		// Token: 0x17000B71 RID: 2929
		// (get) Token: 0x0600AD2D RID: 44333 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600AD2E RID: 44334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B71")]
		public List<InventoryClothInfo> Clothes
		{
			[Token(Token = "0x600AD2D")]
			[Address(RVA = "0x13F3210", Offset = "0x13F3210", VA = "0x7BBBBF3210")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11464BC", Offset = "0x11464BC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600AD2E")]
			[Address(RVA = "0x13F3218", Offset = "0x13F3218", VA = "0x7BBBBF3218")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11464CC", Offset = "0x11464CC")]
			private set
			{
			}
		}

		// Token: 0x0600AD2F RID: 44335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD2F")]
		[Address(RVA = "0x13F3220", Offset = "0x13F3220", VA = "0x7BBBBF3220")]
		public InventoryClothShowingInfo(bool isLegend, [Optional] InventoryClothInfo info)
		{
		}

		// Token: 0x0600AD30 RID: 44336 RVA: 0x0002FE38 File Offset: 0x0002E038
		[Token(Token = "0x600AD30")]
		[Address(RVA = "0x13F3330", Offset = "0x13F3330", VA = "0x7BBBBF3330")]
		public bool HaveId(uint id)
		{
			return default(bool);
		}

		// Token: 0x0600AD31 RID: 44337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AD31")]
		[Address(RVA = "0x13F334C", Offset = "0x13F334C", VA = "0x7BBBBF334C")]
		private InventoryClothInfo GetClothInfoById(uint id)
		{
			return null;
		}

		// Token: 0x0600AD32 RID: 44338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD32")]
		[Address(RVA = "0x13F3428", Offset = "0x13F3428", VA = "0x7BBBBF3428")]
		public void PickId(uint id)
		{
		}

		// Token: 0x0600AD33 RID: 44339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD33")]
		[Address(RVA = "0x13F361C", Offset = "0x13F361C", VA = "0x7BBBBF361C")]
		public void SetType(uint type)
		{
		}

		// Token: 0x0600AD34 RID: 44340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD34")]
		[Address(RVA = "0x13F3624", Offset = "0x13F3624", VA = "0x7BBBBF3624")]
		public void Add(InventoryClothInfo cloth)
		{
		}

		// Token: 0x0600AD35 RID: 44341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD35")]
		[Address(RVA = "0x13F354C", Offset = "0x13F354C", VA = "0x7BBBBF354C")]
		public void PickLevel(int level)
		{
		}

		// Token: 0x0600AD36 RID: 44342 RVA: 0x0002FE50 File Offset: 0x0002E050
		[Token(Token = "0x600AD36")]
		[Address(RVA = "0x13F39DC", Offset = "0x13F39DC", VA = "0x7BBBBF39DC")]
		public int GetCurrentClothLevel()
		{
			return 0;
		}

		// Token: 0x0600AD37 RID: 44343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AD37")]
		[Address(RVA = "0x13F39E4", Offset = "0x13F39E4", VA = "0x7BBBBF39E4")]
		public InventoryClothInfo GetCurrentClothData()
		{
			return null;
		}

		// Token: 0x0600AD38 RID: 44344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AD38")]
		[Address(RVA = "0x13F3938", Offset = "0x13F3938", VA = "0x7BBBBF3938")]
		public InventoryClothInfo GetClothDataByLevel(int level)
		{
			return null;
		}

		// Token: 0x0600AD39 RID: 44345 RVA: 0x0002FE68 File Offset: 0x0002E068
		[Token(Token = "0x600AD39")]
		[Address(RVA = "0x13F39FC", Offset = "0x13F39FC", VA = "0x7BBBBF39FC", Slot = "4")]
		public int CompareTo(InventoryClothShowingInfo other)
		{
			return 0;
		}

		// Token: 0x0600AD3A RID: 44346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD3A")]
		[Address(RVA = "0x13F38A0", Offset = "0x13F38A0", VA = "0x7BBBBF38A0")]
		private void SortByLevel()
		{
		}

		// Token: 0x0600AD3B RID: 44347 RVA: 0x0002FE80 File Offset: 0x0002E080
		[Token(Token = "0x600AD3B")]
		[Address(RVA = "0x13F3A80", Offset = "0x13F3A80", VA = "0x7BBBBF3A80")]
		private int CompareLevel(InventoryClothInfo left, InventoryClothInfo right)
		{
			return 0;
		}

		// Token: 0x0400B18A RID: 45450
		[Token(Token = "0x400B18A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113009C", Offset = "0x113009C")]
		private bool <IsLegend>k__BackingField;

		// Token: 0x0400B18B RID: 45451
		[Token(Token = "0x400B18B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11300AC", Offset = "0x11300AC")]
		private uint <LegendType>k__BackingField;

		// Token: 0x0400B18C RID: 45452
		[Token(Token = "0x400B18C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11300BC", Offset = "0x11300BC")]
		private List<InventoryClothInfo> <Clothes>k__BackingField;

		// Token: 0x0400B18D RID: 45453
		[Token(Token = "0x400B18D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int CurrentLevel;

		// Token: 0x02001ED3 RID: 7891
		[Token(Token = "0x2001ED3")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FCB94", Offset = "0x10FCB94")]
		private sealed class <>c__DisplayClass15_0
		{
			// Token: 0x0600AD3C RID: 44348 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AD3C")]
			[Address(RVA = "0x13F3420", Offset = "0x13F3420", VA = "0x7BBBBF3420")]
			public <>c__DisplayClass15_0()
			{
			}

			// Token: 0x0600AD3D RID: 44349 RVA: 0x0002FE98 File Offset: 0x0002E098
			[Token(Token = "0x600AD3D")]
			[Address(RVA = "0x13F3B68", Offset = "0x13F3B68", VA = "0x7BBBBF3B68")]
			internal bool <GetClothInfoById>b__0(InventoryClothInfo x)
			{
				return default(bool);
			}

			// Token: 0x0400B18E RID: 45454
			[Token(Token = "0x400B18E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public uint id;
		}
	}
}
