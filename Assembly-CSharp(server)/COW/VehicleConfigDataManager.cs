using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using LitJson;
using UnityEngine;

namespace COW
{
	// Token: 0x0200119F RID: 4511
	[Token(Token = "0x200119F")]
	public class VehicleConfigDataManager : SingletonModule<VehicleConfigDataManager>
	{
		// Token: 0x0600462F RID: 17967 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600462F")]
		[Address(RVA = "0x1797928", Offset = "0x1797928", VA = "0x7BBBF97928")]
		public VehicleConfigData GetConfigData(uint mapId, uint modeId, int vehId)
		{
			return null;
		}

		// Token: 0x06004630 RID: 17968 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004630")]
		[Address(RVA = "0x17979D8", Offset = "0x17979D8", VA = "0x7BBBF979D8")]
		internal VehicleConfigDataMap GetConfigData(uint mapId, uint modeId)
		{
			return null;
		}

		// Token: 0x06004631 RID: 17969 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004631")]
		[Address(RVA = "0x1797AB8", Offset = "0x1797AB8", VA = "0x7BBBF97AB8")]
		private VehicleConfigDataMap LoadAndStoreConfigData(uint id)
		{
			return null;
		}

		// Token: 0x06004632 RID: 17970 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004632")]
		[Address(RVA = "0x1797D20", Offset = "0x1797D20", VA = "0x7BBBF97D20")]
		private VehicleConfigDataMap LoadAndStoreDefaultConfigData()
		{
			return null;
		}

		// Token: 0x06004633 RID: 17971 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004633")]
		[Address(RVA = "0x1797D84", Offset = "0x1797D84", VA = "0x7BBBF97D84")]
		private VehicleConfigDataMap LoadAndStoreConfigData(ResourceID resID)
		{
			return null;
		}

		// Token: 0x06004634 RID: 17972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004634")]
		[Address(RVA = "0x179804C", Offset = "0x179804C", VA = "0x7BBBF9804C")]
		public void Clear()
		{
		}

		// Token: 0x06004635 RID: 17973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004635")]
		[Address(RVA = "0x179805C", Offset = "0x179805C", VA = "0x7BBBF9805C", Slot = "6")]
		protected override void OnInit()
		{
		}

		// Token: 0x06004636 RID: 17974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004636")]
		[Address(RVA = "0x1798060", Offset = "0x1798060", VA = "0x7BBBF98060", Slot = "7")]
		protected override void OnCleanup()
		{
		}

		// Token: 0x06004637 RID: 17975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004637")]
		[Address(RVA = "0x1798070", Offset = "0x1798070", VA = "0x7BBBF98070")]
		public VehicleConfigDataManager()
		{
		}

		// Token: 0x0400575C RID: 22364
		[Token(Token = "0x400575C")]
		public const bool CacheConfigs = true;

		// Token: 0x0400575D RID: 22365
		[Token(Token = "0x400575D")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<uint, VehicleConfigDataMap> m_Dic;

		// Token: 0x0400575E RID: 22366
		[Token(Token = "0x400575E")]
		[FieldOffset(Offset = "0x20")]
		private uint m_CurrentDataId;

		// Token: 0x0400575F RID: 22367
		[Token(Token = "0x400575F")]
		[FieldOffset(Offset = "0x28")]
		private VehicleConfigDataMap m_CurrentData;

		// Token: 0x04005760 RID: 22368
		[Token(Token = "0x4005760")]
		[FieldOffset(Offset = "0x30")]
		private VehicleConfigDataMap m_DefaultData;

		// Token: 0x020011A0 RID: 4512
		[Token(Token = "0x20011A0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EAE04", Offset = "0x10EAE04")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06004639 RID: 17977 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004639")]
			[Address(RVA = "0x1798144", Offset = "0x1798144", VA = "0x7BBBF98144")]
			public <>c()
			{
			}

			// Token: 0x0600463A RID: 17978 RVA: 0x000153A8 File Offset: 0x000135A8
			[Token(Token = "0x600463A")]
			[Address(RVA = "0x179814C", Offset = "0x179814C", VA = "0x7BBBF9814C")]
			internal float <LoadAndStoreConfigData>b__9_0(double input)
			{
				return 0f;
			}

			// Token: 0x0600463B RID: 17979 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600463B")]
			[Address(RVA = "0x17981BC", Offset = "0x17981BC", VA = "0x7BBBF981BC")]
			internal BoxCollider <LoadAndStoreConfigData>b__9_1(string input)
			{
				return null;
			}

			// Token: 0x04005761 RID: 22369
			[Token(Token = "0x4005761")]
			[FieldOffset(Offset = "0x0")]
			public static readonly VehicleConfigDataManager.<>c <>9;

			// Token: 0x04005762 RID: 22370
			[Token(Token = "0x4005762")]
			[FieldOffset(Offset = "0x8")]
			public static ImporterFunc<double, float> <>9__9_0;

			// Token: 0x04005763 RID: 22371
			[Token(Token = "0x4005763")]
			[FieldOffset(Offset = "0x10")]
			public static ImporterFunc<string, BoxCollider> <>9__9_1;
		}
	}
}
