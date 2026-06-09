using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using message;
using UnityEngine;

namespace COW.GamePlay
{
	// Token: 0x02002AA9 RID: 10921
	[Token(Token = "0x2002AA9")]
	internal class PlayerReaper : PlayerNetwork
	{
		// Token: 0x17001116 RID: 4374
		// (get) Token: 0x0600EFD8 RID: 61400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001116")]
		public override Collider \u0080Ij~cm[
		{
			[Token(Token = "0x600EFD8")]
			[Address(RVA = "0x1724980", Offset = "0x1724980", VA = "0x7BBBF24980", Slot = "87")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600EFD9 RID: 61401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EFD9")]
		[Address(RVA = "0x1724A20", Offset = "0x1724A20", VA = "0x7BBBF24A20", Slot = "20")]
		protected override void OnUserDefineReplicationInfo()
		{
		}

		// Token: 0x0600EFDA RID: 61402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EFDA")]
		[Address(RVA = "0x1724D70", Offset = "0x1724D70", VA = "0x7BBBF24D70")]
		private void iJnQ\u0080vv(ushort IltNSGB, ushort \u0080~|qSSm)
		{
		}

		// Token: 0x0600EFDB RID: 61403 RVA: 0x00044AA8 File Offset: 0x00042CA8
		[Token(Token = "0x600EFDB")]
		[Address(RVA = "0x1724E44", Offset = "0x1724E44", VA = "0x7BBBF24E44")]
		public uint GetSoul()
		{
			return 0U;
		}

		// Token: 0x0600EFDC RID: 61404 RVA: 0x00044AC0 File Offset: 0x00042CC0
		[Token(Token = "0x600EFDC")]
		[Address(RVA = "0x1724EB0", Offset = "0x1724EB0", VA = "0x7BBBF24EB0")]
		public uint GetEquipSetIndex()
		{
			return 0U;
		}

		// Token: 0x0600EFDD RID: 61405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EFDD")]
		[Address(RVA = "0x1724F1C", Offset = "0x1724F1C", VA = "0x7BBBF24F1C")]
		private void Nl\u0081LM^q(bool IltNSGB, bool \u0080~|qSSm)
		{
		}

		// Token: 0x0600EFDE RID: 61406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EFDE")]
		[Address(RVA = "0x1724FF0", Offset = "0x1724FF0", VA = "0x7BBBF24FF0")]
		private void Ps\u0082r\u0082Bg(ushort IltNSGB, ushort \u0080~|qSSm)
		{
		}

		// Token: 0x0600EFDF RID: 61407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EFDF")]
		[Address(RVA = "0x17250E0", Offset = "0x17250E0", VA = "0x7BBBF250E0")]
		private void \u007FoHEuAa(bool \u0080wZXDUN)
		{
		}

		// Token: 0x0600EFE0 RID: 61408 RVA: 0x00044AD8 File Offset: 0x00042CD8
		[Token(Token = "0x600EFE0")]
		[Address(RVA = "0x17249BC", Offset = "0x17249BC", VA = "0x7BBBF249BC")]
		public bool GetReaperState()
		{
			return default(bool);
		}

		// Token: 0x0600EFE1 RID: 61409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EFE1")]
		[Address(RVA = "0x17252A4", Offset = "0x17252A4", VA = "0x7BBBF252A4")]
		public void TestSetSoulCount(ushort tgAKrr])
		{
		}

		// Token: 0x0600EFE2 RID: 61410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EFE2")]
		[Address(RVA = "0x1725318", Offset = "0x1725318", VA = "0x7BBBF25318", Slot = "102")]
		public override void OnTriggerEnter(Collider mvYAplG)
		{
		}

		// Token: 0x0600EFE3 RID: 61411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EFE3")]
		[Address(RVA = "0x17253CC", Offset = "0x17253CC", VA = "0x7BBBF253CC", Slot = "103")]
		public override void OnTriggerExit(Collider mvYAplG)
		{
		}

		// Token: 0x0600EFE4 RID: 61412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EFE4")]
		[Address(RVA = "0x1725480", Offset = "0x1725480", VA = "0x7BBBF25480", Slot = "48")]
		public override void TakeDamage(woZmHkA JkgWmeJ, [Optional] ohSG[ek \u0081{zLQ\u007FM, [Optional] List<float> `KEFVvE, uint iYO}d|F = 0U)
		{
		}

		// Token: 0x0600EFE5 RID: 61413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EFE5")]
		[Address(RVA = "0x1725A14", Offset = "0x1725A14", VA = "0x7BBBF25A14", Slot = "99")]
		public override void Dead(int HayvOap, {QAb\u0082~u zlP\u0080iaN, bool mHzuEX~ = false, bool w{NtXzW = false)
		{
		}

		// Token: 0x0600EFE6 RID: 61414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EFE6")]
		[Address(RVA = "0x1725CB0", Offset = "0x1725CB0", VA = "0x7BBBF25CB0")]
		private void }HhkJ(Transform VT`lIxO)
		{
		}

		// Token: 0x17001117 RID: 4375
		// (get) Token: 0x0600EFE7 RID: 61415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001117")]
		private Transform EpvMUj\u0082
		{
			[Token(Token = "0x600EFE7")]
			[Address(RVA = "0x17258A4", Offset = "0x17258A4", VA = "0x7BBBF258A4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001118 RID: 4376
		// (get) Token: 0x0600EFE8 RID: 61416 RVA: 0x00044AF0 File Offset: 0x00042CF0
		// (set) Token: 0x0600EFE9 RID: 61417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001118")]
		private bool \u0082}YIegp
		{
			[Token(Token = "0x600EFE8")]
			[Address(RVA = "0x172589C", Offset = "0x172589C", VA = "0x7BBBF2589C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114AA5C", Offset = "0x114AA5C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600EFE9")]
			[Address(RVA = "0x1726064", Offset = "0x1726064", VA = "0x7BBBF26064")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114AA6C", Offset = "0x114AA6C")]
			set
			{
			}
		}

		// Token: 0x0600EFEA RID: 61418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EFEA")]
		[Address(RVA = "0x1726070", Offset = "0x1726070", VA = "0x7BBBF26070", Slot = "221")]
		protected override void zhJRf\u0081b(JECPJUw whqcWqF)
		{
		}

		// Token: 0x0600EFEB RID: 61419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EFEB")]
		[Address(RVA = "0x1726628", Offset = "0x1726628", VA = "0x7BBBF26628", Slot = "222")]
		public override void RequestExitTransform()
		{
		}

		// Token: 0x0600EFEC RID: 61420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EFEC")]
		[Address(RVA = "0x17267DC", Offset = "0x17267DC", VA = "0x7BBBF267DC", Slot = "223")]
		protected override void MZah\u0082cM()
		{
		}

		// Token: 0x0600EFED RID: 61421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EFED")]
		[Address(RVA = "0x1726494", Offset = "0x1726494", VA = "0x7BBBF26494")]
		private void \u0081|CbRra(bool jeFp``a)
		{
		}

		// Token: 0x0600EFEE RID: 61422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EFEE")]
		[Address(RVA = "0x172699C", Offset = "0x172699C", VA = "0x7BBBF2699C", Slot = "190")]
		public override void OnActSkillFinished([JfMv\u0082} Gbf\u0082KIG)
		{
		}

		// Token: 0x0600EFEF RID: 61423 RVA: 0x00044B08 File Offset: 0x00042D08
		[Token(Token = "0x600EFEF")]
		[Address(RVA = "0x1724FA0", Offset = "0x1724FA0", VA = "0x7BBBF24FA0")]
		private ResourceID GREKeWX()
		{
			return default(ResourceID);
		}

		// Token: 0x0600EFF0 RID: 61424 RVA: 0x00044B20 File Offset: 0x00042D20
		[Token(Token = "0x600EFF0")]
		[Address(RVA = "0x1726384", Offset = "0x1726384", VA = "0x7BBBF26384")]
		private ResourceID mF}SRUd()
		{
			return default(ResourceID);
		}

		// Token: 0x0600EFF1 RID: 61425 RVA: 0x00044B38 File Offset: 0x00042D38
		[Token(Token = "0x600EFF1")]
		[Address(RVA = "0x1726AE8", Offset = "0x1726AE8", VA = "0x7BBBF26AE8", Slot = "181")]
		public override bool IsIgonreWeaponFireControl()
		{
			return default(bool);
		}

		// Token: 0x0600EFF2 RID: 61426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EFF2")]
		[Address(RVA = "0x1726B00", Offset = "0x1726B00", VA = "0x7BBBF26B00", Slot = "182")]
		public override Dictionary<int, int> GetGameControlMappingToSkillIndexMap()
		{
			return null;
		}

		// Token: 0x0600EFF3 RID: 61427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EFF3")]
		[Address(RVA = "0x1726B08", Offset = "0x1726B08", VA = "0x7BBBF26B08", Slot = "183")]
		public override Dictionary<KeyCode, int> GetKeyCodeToSkillIndexMap()
		{
			return null;
		}

		// Token: 0x0600EFF4 RID: 61428 RVA: 0x00044B50 File Offset: 0x00042D50
		[Token(Token = "0x600EFF4")]
		[Address(RVA = "0x1726B10", Offset = "0x1726B10", VA = "0x7BBBF26B10", Slot = "184")]
		public override bool IsOverrdieFastRunControl()
		{
			return default(bool);
		}

		// Token: 0x0600EFF5 RID: 61429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EFF5")]
		[Address(RVA = "0x1726B20", Offset = "0x1726B20", VA = "0x7BBBF26B20", Slot = "271")]
		public override void ShowAttMsg(string ~S`Xinb)
		{
		}

		// Token: 0x0600EFF6 RID: 61430 RVA: 0x00044B68 File Offset: 0x00042D68
		[Token(Token = "0x600EFF6")]
		[Address(RVA = "0x1726B60", Offset = "0x1726B60", VA = "0x7BBBF26B60", Slot = "185")]
		public override bool IsIgnorePlayerAudioComponent()
		{
			return default(bool);
		}

		// Token: 0x0600EFF7 RID: 61431 RVA: 0x00044B80 File Offset: 0x00042D80
		[Token(Token = "0x600EFF7")]
		[Address(RVA = "0x1726B64", Offset = "0x1726B64", VA = "0x7BBBF26B64", Slot = "186")]
		public override bool IsIgnoreHighFalling()
		{
			return default(bool);
		}

		// Token: 0x0600EFF8 RID: 61432 RVA: 0x00044B98 File Offset: 0x00042D98
		[Token(Token = "0x600EFF8")]
		[Address(RVA = "0x1726B68", Offset = "0x1726B68", VA = "0x7BBBF26B68", Slot = "187")]
		public override bool IsNeedAimAssists()
		{
			return default(bool);
		}

		// Token: 0x0600EFF9 RID: 61433 RVA: 0x00044BB0 File Offset: 0x00042DB0
		[Token(Token = "0x600EFF9")]
		[Address(RVA = "0x1726B80", Offset = "0x1726B80", VA = "0x7BBBF26B80", Slot = "43")]
		public override Vector3 GetAttackableCenterWS()
		{
			return default(Vector3);
		}

		// Token: 0x0600EFFA RID: 61434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EFFA")]
		[Address(RVA = "0x1726C3C", Offset = "0x1726C3C", VA = "0x7BBBF26C3C")]
		public PlayerReaper()
		{
		}

		// Token: 0x0600EFFB RID: 61435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EFFB")]
		[Address(RVA = "0x1726DE4", Offset = "0x1726DE4", VA = "0x7BBBF26DE4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114AA7C", Offset = "0x114AA7C")]
		private void eKjr\u0081\u0081n()
		{
		}

		// Token: 0x040116BF RID: 71359
		[Token(Token = "0x40116BF")]
		private const string r\u0080Qmvli = "Bip01";

		// Token: 0x040116C0 RID: 71360
		[Token(Token = "0x40116C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB30")]
		private Transform Pp{dwVA;

		// Token: 0x040116C1 RID: 71361
		[Token(Token = "0x40116C1")]
		private const int F|nVx = 0;

		// Token: 0x040116C2 RID: 71362
		[Token(Token = "0x40116C2")]
		private const int lDUGg|g = 1;

		// Token: 0x040116C3 RID: 71363
		[Token(Token = "0x40116C3")]
		private const int MiBfd{y = 2;

		// Token: 0x040116C4 RID: 71364
		[Token(Token = "0x40116C4")]
		private const int Q\u0082HnGQT = 3;

		// Token: 0x040116C5 RID: 71365
		[Token(Token = "0x40116C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB38")]
		private GameObject t\u0082kW|X\u0081;

		// Token: 0x040116C6 RID: 71366
		[Token(Token = "0x40116C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1131A44", Offset = "0x1131A44")]
		private bool <HmDWoLI>k__BackingField;

		// Token: 0x040116C7 RID: 71367
		[Token(Token = "0x40116C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB48")]
		private GameObject ^jLIvfC;

		// Token: 0x040116C8 RID: 71368
		[Token(Token = "0x40116C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB50")]
		private Dictionary<int, int> <<EMPTY_NAME>>;

		// Token: 0x040116C9 RID: 71369
		[Token(Token = "0x40116C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB58")]
		private Dictionary<KeyCode, int> YqDSujM;

		// Token: 0x02002AAA RID: 10922
		[Token(Token = "0x2002AAA")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FF0F0", Offset = "0x10FF0F0")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600EFFD RID: 61437 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EFFD")]
			[Address(RVA = "0x1726E54", Offset = "0x1726E54", VA = "0x7BBBF26E54")]
			public <>c()
			{
			}

			// Token: 0x0600EFFE RID: 61438 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EFFE")]
			[Address(RVA = "0x1726E5C", Offset = "0x1726E5C", VA = "0x7BBBF26E5C")]
			internal void T{ks{]y()
			{
			}

			// Token: 0x040116CA RID: 71370
			[Token(Token = "0x40116CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly PlayerReaper.<>c <>9;

			// Token: 0x040116CB RID: 71371
			[Token(Token = "0x40116CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Action <>9__15_0;
		}
	}
}
