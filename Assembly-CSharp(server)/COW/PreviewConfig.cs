using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001170 RID: 4464
	[Token(Token = "0x2001170")]
	[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0x10EADA4", Offset = "0x10EADA4")]
	[Serializable]
	public class PreviewConfig : ScriptableObject
	{
		// Token: 0x06004583 RID: 17795 RVA: 0x00015228 File Offset: 0x00013428
		[Token(Token = "0x6004583")]
		[Address(RVA = "0x1748028", Offset = "0x1748028", VA = "0x7BBBF48028")]
		private int GetIndexByUIType(EFrontendUIType ui_type)
		{
			return 0;
		}

		// Token: 0x06004584 RID: 17796 RVA: 0x00015240 File Offset: 0x00013440
		[Token(Token = "0x6004584")]
		[Address(RVA = "0x17480DC", Offset = "0x17480DC", VA = "0x7BBBF480DC")]
		private int GetSubIndexByCollectionSubType(uint subType)
		{
			return 0;
		}

		// Token: 0x06004585 RID: 17797 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004585")]
		[Address(RVA = "0x17480E8", Offset = "0x17480E8", VA = "0x7BBBF480E8")]
		public PreviewConfig.PreviewOneItem GetConfig(EFrontendUIType ui_type, uint collection_subType)
		{
			return null;
		}

		// Token: 0x06004586 RID: 17798 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004586")]
		[Address(RVA = "0x17484AC", Offset = "0x17484AC", VA = "0x7BBBF484AC")]
		public PreviewConfig.PreviewOneConifg GetPreviewItemByIndex(EFrontendUIType ui_type)
		{
			return null;
		}

		// Token: 0x06004587 RID: 17799 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004587")]
		[Address(RVA = "0x17481A4", Offset = "0x17481A4", VA = "0x7BBBF481A4")]
		public PreviewConfig.PreviewOneItem GetConfig(int index, int subindex)
		{
			return null;
		}

		// Token: 0x06004588 RID: 17800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004588")]
		[Address(RVA = "0x17485F8", Offset = "0x17485F8", VA = "0x7BBBF485F8")]
		public PreviewConfig()
		{
		}

		// Token: 0x0400565D RID: 22109
		[Token(Token = "0x400565D")]
		[FieldOffset(Offset = "0x18")]
		public List<PreviewConfig.PreviewOneConifg> previewlist;

		// Token: 0x02001171 RID: 4465
		[Token(Token = "0x2001171")]
		[Serializable]
		public class PreviewOneConifg
		{
			// Token: 0x06004589 RID: 17801 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004589")]
			[Address(RVA = "0x1748600", Offset = "0x1748600", VA = "0x7BBBF48600")]
			public PreviewOneConifg()
			{
			}

			// Token: 0x0400565E RID: 22110
			[Token(Token = "0x400565E")]
			[FieldOffset(Offset = "0x10")]
			public PreviewConfig.PreviewOneItem previewjetpack;

			// Token: 0x0400565F RID: 22111
			[Token(Token = "0x400565F")]
			[FieldOffset(Offset = "0x18")]
			public PreviewConfig.PreviewOneItem previewbootbox;

			// Token: 0x04005660 RID: 22112
			[Token(Token = "0x4005660")]
			[FieldOffset(Offset = "0x20")]
			public PreviewConfig.PreviewOneItem previewparate;

			// Token: 0x04005661 RID: 22113
			[Token(Token = "0x4005661")]
			[FieldOffset(Offset = "0x28")]
			public PreviewConfig.PreviewOneItem previewskyboard;

			// Token: 0x04005662 RID: 22114
			[Token(Token = "0x4005662")]
			[FieldOffset(Offset = "0x30")]
			public PreviewConfig.PreviewOneItem previewweapon;

			// Token: 0x04005663 RID: 22115
			[Token(Token = "0x4005663")]
			[FieldOffset(Offset = "0x38")]
			public PreviewConfig.PreviewOneItem previewmeleeweapon;

			// Token: 0x04005664 RID: 22116
			[Token(Token = "0x4005664")]
			[FieldOffset(Offset = "0x40")]
			public PreviewConfig.PreviewOneItem previewgrenadeweapon;

			// Token: 0x04005665 RID: 22117
			[Token(Token = "0x4005665")]
			[FieldOffset(Offset = "0x48")]
			public PreviewConfig.PreviewOneItem previewvehicleskin;

			// Token: 0x04005666 RID: 22118
			[Token(Token = "0x4005666")]
			[FieldOffset(Offset = "0x50")]
			public PreviewConfig.PreviewOneItem previewcamera;

			// Token: 0x04005667 RID: 22119
			[Token(Token = "0x4005667")]
			[FieldOffset(Offset = "0x58")]
			public PreviewConfig.PreviewOneItem previewredenvelope;

			// Token: 0x04005668 RID: 22120
			[Token(Token = "0x4005668")]
			[FieldOffset(Offset = "0x60")]
			public PreviewConfig.PreviewOneItem previewPetCat;

			// Token: 0x04005669 RID: 22121
			[Token(Token = "0x4005669")]
			[FieldOffset(Offset = "0x68")]
			public PreviewConfig.PreviewOneItem previewFlight;

			// Token: 0x0400566A RID: 22122
			[Token(Token = "0x400566A")]
			[FieldOffset(Offset = "0x70")]
			public Vector4 previewmiddlePoint;
		}

		// Token: 0x02001172 RID: 4466
		[Token(Token = "0x2001172")]
		[Serializable]
		public class PreviewOneItem
		{
			// Token: 0x0600458A RID: 17802 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600458A")]
			[Address(RVA = "0x1748608", Offset = "0x1748608", VA = "0x7BBBF48608")]
			public PreviewOneItem()
			{
			}

			// Token: 0x0400566B RID: 22123
			[Token(Token = "0x400566B")]
			[FieldOffset(Offset = "0x10")]
			public Vector3 transfrom;

			// Token: 0x0400566C RID: 22124
			[Token(Token = "0x400566C")]
			[FieldOffset(Offset = "0x1C")]
			public Vector3 rotation;

			// Token: 0x0400566D RID: 22125
			[Token(Token = "0x400566D")]
			[FieldOffset(Offset = "0x28")]
			public Vector3 scale;
		}
	}
}
