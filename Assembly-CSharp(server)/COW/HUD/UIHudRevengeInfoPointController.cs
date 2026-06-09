using System;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.HUD
{
	// Token: 0x02002674 RID: 9844
	[Token(Token = "0x2002674")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FE320", Offset = "0x10FE320")]
	public class UIHudRevengeInfoPointController : UIHudNameBaseController
	{
		// Token: 0x17000DA7 RID: 3495
		// (get) Token: 0x0600CB5F RID: 52063 RVA: 0x00036A08 File Offset: 0x00034C08
		// (set) Token: 0x0600CB60 RID: 52064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000DA7")]
		public bool b
		{
			[Token(Token = "0x600CB5F")]
			[Address(RVA = "0x177F544", Offset = "0x177F544", VA = "0x7BBBF7F544")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1148A80", Offset = "0x1148A80")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600CB60")]
			[Address(RVA = "0x177F54C", Offset = "0x177F54C", VA = "0x7BBBF7F54C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1148A90", Offset = "0x1148A90")]
			set
			{
			}
		}

		// Token: 0x0600CB61 RID: 52065 RVA: 0x00036A20 File Offset: 0x00034C20
		[Token(Token = "0x600CB61")]
		[Address(RVA = "0x177F558", Offset = "0x177F558", VA = "0x7BBBF7F558")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600CB62 RID: 52066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CB62")]
		[Address(RVA = "0x177F5A8", Offset = "0x177F5A8", VA = "0x7BBBF7F5A8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600CB63 RID: 52067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CB63")]
		[Address(RVA = "0x177F60C", Offset = "0x177F60C", VA = "0x7BBBF7F60C")]
		public void BindEnermy({QAb\u0082~u hrVa^WJ)
		{
		}

		// Token: 0x0600CB64 RID: 52068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CB64")]
		[Address(RVA = "0x177F62C", Offset = "0x177F62C", VA = "0x7BBBF7F62C")]
		public void UnBindEnermy()
		{
		}

		// Token: 0x0600CB65 RID: 52069 RVA: 0x00036A38 File Offset: 0x00034C38
		[Token(Token = "0x600CB65")]
		[Address(RVA = "0x177F6B4", Offset = "0x177F6B4", VA = "0x7BBBF7F6B4", Slot = "29")]
		protected override bool NeedAutoScaleByDistance()
		{
			return default(bool);
		}

		// Token: 0x0600CB66 RID: 52070 RVA: 0x00036A50 File Offset: 0x00034C50
		[Token(Token = "0x600CB66")]
		[Address(RVA = "0x177F6BC", Offset = "0x177F6BC", VA = "0x7BBBF7F6BC", Slot = "31")]
		protected override bool NeedUpdatePosition()
		{
			return default(bool);
		}

		// Token: 0x0600CB67 RID: 52071 RVA: 0x00036A68 File Offset: 0x00034C68
		[Token(Token = "0x600CB67")]
		[Address(RVA = "0x177FAAC", Offset = "0x177FAAC", VA = "0x7BBBF7FAAC", Slot = "28")]
		protected override Vector3 TargetPosition()
		{
			return default(Vector3);
		}

		// Token: 0x0600CB68 RID: 52072 RVA: 0x00036A80 File Offset: 0x00034C80
		[Token(Token = "0x600CB68")]
		[Address(RVA = "0x177FC40", Offset = "0x177FC40", VA = "0x7BBBF7FC40")]
		private Vector3 gWjVKco(Player bqdVnD\u007F)
		{
			return default(Vector3);
		}

		// Token: 0x0600CB69 RID: 52073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CB69")]
		[Address(RVA = "0x177FDD8", Offset = "0x177FDD8", VA = "0x7BBBF7FDD8")]
		public UIHudRevengeInfoPointController()
		{
		}

		// Token: 0x0400FFA5 RID: 65445
		[Token(Token = "0x400FFA5")]
		[FieldOffset(Offset = "0xA8")]
		private UIHudRevengeInfoPointView p|r\u007Fnuf;

		// Token: 0x0400FFA6 RID: 65446
		[Token(Token = "0x400FFA6")]
		[FieldOffset(Offset = "0xB0")]
		private {QAb\u0082~u ^ee]Be;

		// Token: 0x0400FFA7 RID: 65447
		[Token(Token = "0x400FFA7")]
		[FieldOffset(Offset = "0xC8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1130B7C", Offset = "0x1130B7C")]
		private bool <\u007FzArO^F>k__BackingField;
	}
}
